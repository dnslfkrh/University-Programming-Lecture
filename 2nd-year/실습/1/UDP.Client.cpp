#include <iostream>
#include <winsock2.h>
#include <ws2tcpip.h>
#include <string>
#pragma comment(lib, "ws2_32.lib")

#define PORT 8080
#define BUFFER_SIZE 1024

int main() {
    WSADATA wsaData;
    SOCKET sockfd;
    struct sockaddr_in servaddr;
    char buffer[BUFFER_SIZE];
    std::string message;

    if (WSAStartup(MAKEWORD(2, 2), &wsaData) != 0) {
        std::cerr << "WSAStartup failed" << std::endl;
        return 1;
    }

    sockfd = socket(AF_INET, SOCK_DGRAM, 0);
    if (sockfd == INVALID_SOCKET) {
        std::cerr << "Socket creation failed: " << WSAGetLastError() << std::endl;
        WSACleanup();
        return 1;
    }

    servaddr.sin_family = AF_INET;
    servaddr.sin_port = htons(PORT);

    if (InetPtonA(AF_INET, "127.0.0.1", &servaddr.sin_addr) != 1) {
        std::cerr << "Invalid address/ Address not supported" << std::endl;
        closesocket(sockfd);
        WSACleanup();
        return 1;
    }

    while (true) {
        std::cout << "Enter message (type 'exit' to quit): ";
        std::getline(std::cin, message);

        if (message == "exit") {
            break;
        }

        sendto(sockfd, message.c_str(), message.length(), 0, (struct sockaddr*)&servaddr, sizeof(servaddr));

        int servaddr_len = sizeof(servaddr);
        int n = recvfrom(sockfd, buffer, BUFFER_SIZE, 0, (struct sockaddr*)&servaddr, &servaddr_len);
        if (n == SOCKET_ERROR) {
            std::cerr << "Receive failed: " << WSAGetLastError() << std::endl;
            break;
        }

        buffer[n] = '\0';
        std::cout << "Server: " << buffer << std::endl;
    }

    closesocket(sockfd);
    WSACleanup();
    return 0;
}
