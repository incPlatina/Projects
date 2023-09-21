
#include "GameObject.cpp"

// ����� ��� ������������� ����
class Bullet : public GameObject {
public:
    int speed;

    Bullet(int x, int y, char symbol, string color, int speed) : GameObject(x, y, symbol, color) {
        this->speed = speed;
    }

    // ����� ��� ���������� ��������� ����
    void update() {
        moveVertical(speed);
    }
};
