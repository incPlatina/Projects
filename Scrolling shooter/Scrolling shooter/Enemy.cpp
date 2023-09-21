

#include "GameObject.cpp"

// ����� ��� ������������� ����������
class Enemy : public GameObject {
public:
    int speed;

    // ����������� � �����������
    Enemy(int x, int y, char symbol, string color, int speed) : GameObject(x, y, symbol, color) {
        this->speed = speed;
    }

    // ����� ��� ���������� ��������� ����������
    void update() {
        moveVertical(speed);
    }
};