
#include "GameObject.cpp"

// Класс для представления игрока
class Player : public GameObject {
public:

    int lives;

    // Конструктор с параметрами
    Player(int x, int y, char symbol, string color, int lives) : GameObject(x, y, symbol, color) {
        this->lives = lives;
    }
};