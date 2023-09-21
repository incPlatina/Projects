
#include "GameObject.cpp"

// ����� ��� ������������� ������
class Player : public GameObject {
public:

    int lives;

    // ����������� � �����������
    Player(int x, int y, char symbol, string color, int lives) : GameObject(x, y, symbol, color) {
        this->lives = lives;
    }
};