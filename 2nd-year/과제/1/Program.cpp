#include <iostream>

using namespace std;

void displayStartScreen() {
	system("cls");
	cout << "------------------------------------" << endl;
	cout << "서점" << endl;
	cout << "------------------------------------" << endl;
	cout << "설명:" << endl;
	cout << "(1) 도서의 검색과 관리 프로그램" << endl;
	cout << "(2) 고객의 검색과 관리" << endl;
	cout << "(3) 고객의 도서 판매 관리" << endl;
	cout << "------------------------------------" << endl;
	cout << "시작하시려면 아무 키나 눌러 주세요~" << endl;
	cin.get();
	cin.ignore(); 
}

int displayMenu() {
	system("cls");
	int choice;
	cout << "------------------------------------" << endl;
	cout << "1. 도서 관리" << endl;
	cout << "2. 고객 관리" << endl;
	cout << "3. 도서 판매 관리" << endl;
	cout << "4. 종료" << endl;
	cout << "------------------------------------" << endl;
	cout << "원하는 번호를 입력하세요: ";
	cin >> choice;
	cin.ignore();
	return choice;
}

//--------------------도서 관리----------------------------
void bookList() {
	system("cls");

	cout << "모든 도서가 여기에 표시됩니다." << endl;
}

void findBook() {
	system("cls");

	cout << "찾으시는 도서 번호를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "검색하신 도서입니다." << endl;
}

void addBook() {
	system("cls");

	cout << "등록하실 도서 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "도서 등록이 완료되었습니다." << endl;
}

void deleteBook() {
	system("cls");

	cout << "삭제하실 도서 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "도서 삭제가 완료되었습니다." << endl;
}

void editBook() {
	system("cls");

	cout << "수정하실 도서 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "도서 정보를 수정하세요." << endl;
	cin.get();
	cin.ignore();
	cout << "도서 수정이 완료되었습니다." << endl;
}

void bookManage() {
	system("cls");

	int choice;
	cout << "------------------------------------" << endl;
	cout << "0. 모든 도서 보기" << endl;
	cout << "1. 도서 찾기" << endl;
	cout << "2. 도서 등록하기" << endl;
	cout << "3. 도서 지우기" << endl;
	cout << "4. 도서 수정" << endl;
	cout << "5. 메인 메뉴" << endl;
	cout << "------------------------------------" << endl;
	cout << "원하시는 번호를 입력하세요: ";
	cin >> choice;
	cin.ignore();

	switch (choice) {
	case 0:
		bookList();
		cin.ignore();
		break;
	case 1:
		findBook();
		cin.ignore();
		break;
	case 2:
		addBook();
		cin.ignore();
		break;
	case 3:
		deleteBook();
		cin.ignore();
		break;
	case 4:
		editBook();
		cin.ignore();
		break;
	case 5:
		break;
	default:
		cout << "잘못된 입력입니다. 다시 입력하세요." << endl;
		break;
	}
}
//--------------------도서 관리----------------------------

//--------------------유저 관리----------------------------
void userList() {
	system("cls");

	cout << "모든 고객이 여기에 표시됩니다." << endl;
}

void findUser() {
	system("cls");

	cout << "찾으시는 고객 번호를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "검색하신 고객입니다." << endl;
}

void addUser() {
	system("cls");

	cout << "등록하실 고객 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "고객 등록이 완료되었습니다." << endl;
}

void deleteUser() {
	system("cls");

	cout << "삭제하실 고객 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "고객 삭제가 완료되었습니다." << endl;
}

void editUser() {
	system("cls");

	cout << "수정하실 고객 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "고객 정보를 수정하세요." << endl;
	cin.get();
	cin.ignore();
	cout << "고객 수정이 완료되었습니다." << endl;
}

void userManage() {
	system("cls");

	int choice;
	cout << "------------------------------------" << endl;
	cout << "0. 모든 고객 보기" << endl;
	cout << "1. 고객 찾기" << endl;
	cout << "2. 고객 등록하기" << endl;
	cout << "3. 고객 지우기" << endl;
	cout << "4. 고객 수정" << endl;
	cout << "5. 메인 메뉴" << endl;
	cout << "------------------------------------" << endl;
	cout << "원하시는 번호를 입력하세요: ";
	cin >> choice;
	cin.ignore();

	switch (choice) {
	case 0:
		userList();
		cin.ignore();
		break;
	case 1:
		findUser();
		cin.ignore();
		break;
	case 2:
		addUser();
		cin.ignore();
		break;
	case 3:
		deleteUser();
		cin.ignore();
		break;
	case 4:
		editUser();
		cin.ignore();
		break;
	case 5:
		break;
	default:
		cout << "잘못된 입력입니다. 다시 입력하세요." << endl;
		break;
	}
}
//--------------------유저 관리----------------------------

//--------------------판매 관리----------------------------
void deliveryTracking() {
	system("cls");

	cout << "배송 조회하실 고객 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "해당 고객의 배송 추적 내용입니다." << endl;
}

void orderHistory() {
	system("cls");

	cout << "조회하실 고객 정보를 입력해 주세요." << endl;
	cin.get();
	cin.ignore();
	cout << "해당 고객의 주문 내역입니다." << endl;
}

void buyingManage() {
	system("cls");

	int choice;
	cout << "------------------------------------" << endl;
	cout << "0. 배송 조회" << endl;
	cout << "1. 주문 내역" << endl;
	cout << "------------------------------------" << endl;
	cout << "원하시는 번호를 입력하세요: ";
	cin >> choice;
	cin.ignore();

	switch (choice) {
	case 0:
		deliveryTracking();
		cin.ignore();
		break;
	case 1:
		orderHistory();
		cin.ignore();
		break;
	default:
		cout << "잘못된 입력입니다. 다시 입력하세요." << endl;
		break;
	}
}
//--------------------판매 관리----------------------------

int main() {
	int menuChoice;

	displayStartScreen();

	do {
		menuChoice = displayMenu();
		switch (menuChoice) {
		case 1:
			bookManage();
			break;
		case 2:
			userManage();
			break;
		case 3:
			buyingManage();
			break;
		case 4:
			cout << "프로그램을 종료합니다." << endl;
			break;
		default:
			cout << "잘못된 입력입니다. 다시 입력하세요." << endl;
		}
	} while (menuChoice != 4);

	return 0;
}