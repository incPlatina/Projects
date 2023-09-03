#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Weight {
public:
    virtual void Info() = 0;
};

class Weapon {
public:
    virtual void Info() = 0;
};

class WeightCorvette : public Weight {
public:
    void Info() override {
        cout << "Вес корвета: 100 тонн" << endl;
    }
};

class WeightDestroyer : public Weight {
public:
    void Info() override {
        cout << "Вес эсминца: 200 тонн" << endl;
    }
};

class WeightCruiser : public Weight {
public:
    void Info() override {
        cout << "Вес крейсера: 300 тонн" << endl;
    }
};

class WeaponCorvette : public Weapon {
public:
    void Info() override {
        cout << "Вооружение корвета: лазерная пушка" << endl;
    }
};

class WeaponDestroyer : public Weapon {
public:
    void Info() override {
        cout << "Вооружение эсминца: ракетный комплекс" << endl;
    }
};

class WeaponCruiser : public Weapon {
public:
    void Info() override {
        cout << "Вооружение крейсера: плазменный залп" << endl;
    }
};

class Abstract {
public:
    virtual Weight* CreateWeight() = 0;
    virtual Weapon* CreateWeapon() = 0;
};


class Corvette : public Abstract {

public:
    
    Weight* CreateWeight() override {
        return new WeightCorvette();
    }

    Weapon* CreateWeapon() override {
        return new WeaponCorvette();
    }
};

class Destroyer : public Abstract {

public:
    Weight* CreateWeight() override {
        return new WeightDestroyer();
    }

    Weapon* CreateWeapon() override {
        return new WeaponDestroyer();
    }
};



class Cruiser : public Abstract {

public:
    Weight* CreateWeight() override {
        return new WeightCruiser();
    }

    Weapon* CreateWeapon() override {
        return new WeaponCruiser();
    }
};


class Fleet
{
public:
    vector<Weight*> weights;
    vector<Weapon*> weapons;

    void Produce(Abstract* A)
    {
        weights.push_back(A->CreateWeight());
        weapons.push_back(A->CreateWeapon());
    }

    void Info()
    {
        for (int i = 0; i < weights.size(); i++) {
            weights[i]->Info();
            weapons[i]->Info();
            cout << "-----------------------------" << endl;
        }
    }
    ~Fleet() {
        for (auto a : weights) { delete a; }
        for (auto b : weapons) { delete b; }
    }
};

int main()
{
    setlocale(LC_ALL, "Russian");
    Abstract* st;
    Fleet FL = Fleet();

    st = new Corvette();
    FL.Produce(st);

    st = new Destroyer();
    FL.Produce(st);

    st = new Cruiser();
    FL.Produce(st);

    FL.Info();

    delete st;
    return 0;
}
