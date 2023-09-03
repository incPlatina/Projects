#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

class Wallet {
protected:
    Wallet* next; 
    int balance; 
public:
    Wallet(int b) {
        next = 0; 
        balance = b; 
    }
    void setLast() {
        next = 0; 
    }
    void addWallet(Wallet* w) {
        if (next) {
            next->addWallet(w);
        }
        else {
            next = w;
        }
    }
    virtual void handle(int amount) = 0;
};

class Wallet1 : public Wallet {
public:
    Wallet1(int b) : Wallet(b) {} 
    void handle(int amount) override {
        if (balance >= amount) {
            balance -= amount;
            cout << "Оплачено " << amount << " из Кошелька1. Баланс: " << balance << endl;
        }
        else {
            cout << "Недостаточно средств в Кошельке1. Баланс: " << balance << endl;
            if (next == 0) {
                cout << "Оплата не удалась." << endl;
                return;
            }
            else {
                next->handle(amount);
            }
        }
    }
};

class Wallet2 : public Wallet {
public:
    Wallet2(int b) : Wallet(b) {} 
    void handle(int amount) override {
        if (balance >= amount) {
            balance -= amount;
            cout << "Оплачено " << amount << " из Кошелька2. Баланс: " << balance << endl;
        }
        else {
            cout << "Недостаточно средств в Кошельке2. Баланс: " << balance << endl;
            if (next == 0) {
                cout << "Оплата не удалась." << endl;
                return;
            }
            else {
                next->handle(amount);
            }
        }
    }
};

class Wallet3 : public Wallet {
public:
    Wallet3(int b) : Wallet(b) {} 
    void handle(int amount) override {
        if (balance >= amount) {
            balance -= amount;
            cout << "Оплачено " << amount << " из Кошелька3. Баланс: " << balance << endl;
        }
        else {
            cout << "Недостаточно средств в Кошельке3. Баланс: " << balance << endl;
            if (next == 0) {
                cout << "Оплата не удалась." << endl;
                return;
            }
            else {
                next->handle(amount);
            }
        }
    }
};
class Wallet4 : public Wallet {
public:
    Wallet4(int b) : Wallet(b) {}
    void handle(int amount) override {
        if (balance >= amount) {
            balance -= amount;
            cout << "Оплачено " << amount << " из Кошелька4. Баланс: " << balance << endl;
        }
        else {
            cout << "Недостаточно средств в Кошельке4. Баланс: " << balance << endl;
            if (next == 0) {
                cout << "Оплата не удалась." << endl;
                return;
            }
            else {
                next->handle(amount);
            }
        }
    }
};

int main() {
    setlocale(LC_ALL, "Russian");
    Wallet* w1 = new Wallet1(100);
    Wallet* w2 = new Wallet2(200);
    Wallet* w3 = new Wallet3(300);
    Wallet* w4 = new Wallet4(400);

    
    w1->addWallet(w2);
    w1->addWallet(w3);
    w1->addWallet(w4);
    w4->setLast();

    srand(time(0)); 

    for (int i = 0; i < 5; i++) {
        int amount = rand() % 500 + 1; 
        cout << "Пытаемся оплатить " << amount << endl; 
        w1->handle(amount); 
        cout << endl;
    }

    delete w1; 
    delete w2;
    delete w3;

}
