#pragma once
#include "libs.h"

// ����� ��� ������������� �������� �� ������
class GameObject {
public:
    int x, y;
    char symbol;
    string color;

    // ����������� �� ���������
    GameObject() {
        x = 0;
        y = 0;
        symbol = ' ';
        color = "white";
    }

    // ����������� � �����������
    GameObject(int x, int y, char symbol, string color) {
        this->x = x;
        this->y = y;
        this->symbol = symbol;
        this->color = color;
    }

    // ����� ��� ����������� ������� �� �����������
    void moveHorizontal(int dx) {
        x += dx;
        // �������� ������ ������
        if (x < 0) x = 0;
        if (x >= SCREEN_WIDTH) x = SCREEN_WIDTH - 1;
    }

    // ����� ��� ����������� ������� �� ���������
    void moveVertical(int dy) {
        y += dy;
        // �������� ������ ������
        if (y < 0) y = 0;
        if (y >= SCREEN_HEIGHT) y = SCREEN_HEIGHT - 1;
    }

    // ����� ��� �������� ������������ � ������ ��������
    bool collideWith(GameObject& other) {
        return x == other.x && y == other.y;
    }
};