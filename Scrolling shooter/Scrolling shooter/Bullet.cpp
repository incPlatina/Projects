
#include "GameObject.cpp"

// Класс для представления пули
class Bullet : public GameObject {
public:
    int speed;

    Bullet(int x, int y, char symbol, string color, int speed) : GameObject(x, y, symbol, color) {
        this->speed = speed;
    }

    // Метод для обновления положения пули
    void update() {
        moveVertical(speed);
    }
};
