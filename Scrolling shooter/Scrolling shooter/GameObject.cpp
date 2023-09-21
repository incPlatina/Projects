#pragma once
#include "libs.h"

// Класс для представления объектов на экране
class GameObject {
public:
    int x, y;
    char symbol;
    string color;

    // Конструктор по умолчанию
    GameObject() {
        x = 0;
        y = 0;
        symbol = ' ';
        color = "white";
    }

    // Конструктор с параметрами
    GameObject(int x, int y, char symbol, string color) {
        this->x = x;
        this->y = y;
        this->symbol = symbol;
        this->color = color;
    }

    // Метод для перемещения объекта по горизонтали
    void moveHorizontal(int dx) {
        x += dx;
        // Проверка границ экрана
        if (x < 0) x = 0;
        if (x >= SCREEN_WIDTH) x = SCREEN_WIDTH - 1;
    }

    // Метод для перемещения объекта по вертикали
    void moveVertical(int dy) {
        y += dy;
        // Проверка границ экрана
        if (y < 0) y = 0;
        if (y >= SCREEN_HEIGHT) y = SCREEN_HEIGHT - 1;
    }

    // Метод для проверки столкновения с другим объектом
    bool collideWith(GameObject& other) {
        return x == other.x && y == other.y;
    }
};