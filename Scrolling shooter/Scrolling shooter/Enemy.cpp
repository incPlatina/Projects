

#include "GameObject.cpp"

// Класс для представления противника
class Enemy : public GameObject {
public:
    int speed;

    // Конструктор с параметрами
    Enemy(int x, int y, char symbol, string color, int speed) : GameObject(x, y, symbol, color) {
        this->speed = speed;
    }

    // Метод для обновления положения противника
    void update() {
        moveVertical(speed);
    }
};