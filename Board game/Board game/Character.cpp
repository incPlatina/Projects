#pragma once

#include "libs.h"

// ����� ��� ������������� ���������
class Character {
private:
    string name;
    int position;
    int health;
    int bonus;
public:
    // ����������� � �����������
    Character(string n, int p, int h, int b) {
        name = n;
        position = p;
        health = h;
        bonus = b;
    }


    string get_name() {
        return name;
    }

    void set_name(string n) {
        name = n;
    }

    int get_position() {
        return position;
    }

    void set_position(int p) {
        position = p;
    }

    int get_health() {
        return health;
    }

    void set_health(int h) {
        health = h;
    }

    int get_bonus() {
        return bonus;
    }

    void set_bonus(int b) {
        bonus = b;
    }

    // ����� ��� ������ ������
    int roll_dice() {
        return rand() % 6 + 1;
    }

    // ����� ��� ����������� ��������� �� �����
    void move(int dice) {
        position += dice;
        if (position >= BOARD_SIZE) {
            position = BOARD_SIZE - 1;
        }
    }

    // ����� ��� �������� ������� ������ �� ������
    void check_bonus(int bonuses[]) {
        for (int i = 0; i < BONUS_COUNT; i++) {
            if (position == bonuses[i]) {
                bonus = i + 1;
                break;
            }
        }
    }

    // ����� ��� ���������� ������ � ���������
    void apply_bonus(Character& opponent) {
        int dice1;
        int dice2;
        if (bonus % 5 == 0 && bonus)
            bonus = 5;
        else
            bonus %= 5;
        switch (bonus) {
        case 1:
            cout << name << " �������� ��� ���� ������ ������!\n";
            move(roll_dice());
            break;
        case 2:
            cout << name << " ������� ��� ������ � �������� ������������!\n";
            dice1 = roll_dice();
            dice2 = roll_dice();
            cout << "������: " << dice1 << " � " << dice2 << "\n";
            move(max(dice1, dice2));
            break;
        case 3:
            cout << name << " ��������������� ��������!\n";
            health += 20;
            if (health > 100) {
                health = 100;
            }
            break;
        case 4:
            cout << name << " ������� ���� ����������!\n";
            opponent.set_health(opponent.get_health() - 50);
            if (opponent.get_health() < 0) {
                opponent.set_health(0);
            }
            break;
        case 5:
            cout << name << " ��������������� �� ��������� ������!\n";
            position = rand() % BOARD_SIZE;
            break;
        }
        bonus = 0;
    }
};