#include <iostream>
#include <string>
#include <vector>

// Предполагаем, что есть базовый класс Product, который представляет любой продукт в пиццерии
class Product {
public:
    virtual std::string getName() = 0;
    virtual double getPrice() = 0;
    virtual ~Product() {}
};

// Класс Pizza наследует от Product и представляет пиццу без добавок
class Pizza : public Product {
private:
    std::string name; 
    double price; 
public:
    Pizza(const std::string& name, double price) : name(name), price(price) {}
    std::string getName() override {
        return name;
    }
    double getPrice() override {
        return price;
    }
};

// Абстрактный класс Decorator наследует от Product и представляет декоратор для продуктов
class Decorator : public Product {
protected:
    Product* product;
public:
    Decorator(Product* product) : product(product) {}
    std::string getName() override {
        return product->getName();
    }
    double getPrice() override {
        return product->getPrice();
    }
};

// Класс Salad наследует от Decorator и представляет салат как добавку к продукту
class Salad : public Decorator {
private:
    double price; 
public:
    Salad(Product* product, double price) : Decorator(product), price(price) {}
    std::string getName() override {
        return product->getName() + " + салат";
    }
    double getPrice() override {
        return product->getPrice() + price;
    }
};

// Класс Lemonade наследует от Decorator и представляет лимонад как добавку к продукту
class Lemonade : public Decorator {
private:
    double price; 
public:
    Lemonade(Product* product, double price) : Decorator(product), price(price) {}
    std::string getName() override {
        return product->getName() + " + лимонад";
    }
    double getPrice() override {
        return product->getPrice() + price;
    }
};

// Класс Coffee наследует от Decorator и представляет кофе как добавку к продукту
class Coffee : public Decorator {
private:
    double price; 
public:
    Coffee(Product* product, double price) : Decorator(product), price(price) {}
    std::string getName() override {
        return product->getName() + " + кофе";
    }
    double getPrice() override {
        return product->getPrice() + price;
    }
};

// Класс Beer наследует от Decorator и представляет пиво как добавку к продукту
class Beer : public Decorator {
private:
    double price; 
public:
    Beer(Product* product, double price) : Decorator(product), price(price) {}
    std::string getName() override {
        return product->getName() + " + пиво";
    }
    double getPrice() override {
        return product->getPrice() + price;
    }
};

// Функция для вывода информации о продукте на экран
void printProductInfo( Product* product) {
    std::cout << "Название: " << product->getName() << "\n";
    std::cout << "Цена: " << product->getPrice() << "\n";
}

int main() {
    setlocale(LC_ALL, "Russian");
    // Создаем пиццу без добавок
    Product* pizza = new Pizza("Маргарита", 300);
    printProductInfo(pizza); // Название: Маргарита, Цена: 300

    Product* pizzaWithSaladAndLemonade = new Lemonade(new Salad(pizza, 100), 50);
    printProductInfo(pizzaWithSaladAndLemonade); // Название: Маргарита + салат + лимонад, Цена: 450

    Product* pizzaWithCoffeeAndBeer = new Beer(new Coffee(pizza, 80), 70);
    printProductInfo(pizzaWithCoffeeAndBeer); // Название: Маргарита + кофе + пиво, Цена: 450


    delete pizza;
    delete pizzaWithSaladAndLemonade;
    delete pizzaWithCoffeeAndBeer;

    return 0;
}
