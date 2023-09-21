
#include "Character.cpp"
// Класс для представления доски
class Board {
private:
    int size;
    int bonuses[BONUS_COUNT]; // позиции бонусов на доске 
public:

    

    Board(int s) {
        size = s;
        for (int i = 0; i < BONUS_COUNT; i++) { // заполняем массив бонусов случайными числами от 1 до размера доски
            bonuses[i] = rand() % (size - 1) + 1;
        }
        // Проверка на уникальность бонусов
        for (int i = 0; i < BONUS_COUNT - 1; i++) {
            for (int j = i + 1; j < BONUS_COUNT; j++) {
                if (bonuses[i] == bonuses[j]) {
                    bonuses[j] = rand() % (size - 1) + 1;
                    j--; // возвращаемся на шаг назад, чтобы проверить новую позицию снова
                }
            }
        }
    }


    int get_size() {
        return size;
    }

    void set_size(int s) {
        size = s;
    }

    int* get_bonuses() {
        return bonuses;
    }

    void set_bonuses(int b[]) {
        for (int i = 0; i < BONUS_COUNT; i++) {
            bonuses[i] = b[i];
        }
    }

    // Метод для вывода доски на экран
    void print(Character player1, Character player2) {
        cout << "Доска:\n";
        for (int i = 0; i < size; i++) {
            if (i == player1.get_position()) {
                cout << player1.get_name()[0];
            }
            else if (i == player2.get_position()) {
                cout << player2.get_name()[0];
            }
            else {
                cout << "_";
            }
        }
        cout << "\n";
        // Отображение жизней каждого игрока
        cout << player1.get_name() << ": " << player1.get_health() << " HP\n";
        cout << player2.get_name() << ": " << player2.get_health() << " HP\n";
    }

    // Метод для сохранения доски в файл
    void save(Character player1, Character player2) {
        ofstream file("save.txt");
        if (file.is_open()) {
            file << player1.get_name() << " " << player1.get_position() << " " << player1.get_health() << " " << player1.get_bonus() << "\n";
            file << player2.get_name() << " " << player2.get_position() << " " << player2.get_health() << " " << player2.get_bonus() << "\n";
            for (int i = 0; i < BONUS_COUNT; i++) {
                file << bonuses[i] << " ";
            }
            file.close();
            cout << "Игра сохранена!\n";
        }
        else {
            cout << "Ошибка при сохранении игры!\n";
        }
    }

    // Метод для загрузки доски из файла
    bool load(Character& player1, Character& player2) {
        ifstream file("save.txt");
        if (file.is_open()) {
            string name; int position, health, bonus;
            file >> name >> position >> health >> bonus;
            player1.set_name(name);
            player1.set_position(position);
            player1.set_health(health);
            player1.set_bonus(bonus);

            file >> name >> position >> health >> bonus;
            player2.set_name(name);
            player2.set_position(position);
            player2.set_health(health);
            player2.set_bonus(bonus);

            for (int i = 0; i < BONUS_COUNT; i++) {
                file >> bonuses[i];
            }
            file.close();
            cout << "Игра загружена!\n";
            return true;
        }
        else {
            cout << "Ошибка при загрузке игры!\n";
            return false;
        }
    }
};