// Настольная игра на двух игроков, бросаешь кубик и ходишь
// Есть бонусы: телепортация, повторный бросок, максимальный из двух кубиков,восстановление здоровья, нанесение урона
// Есть персонажи и сохранение/загрузка

#include "libs.h"
#include "Character.cpp"
#include "Board.cpp"

int main() {
    srand(time(NULL));
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    Board board(BOARD_SIZE);

    cout << "Введите имя игрока 1: ";
    string name1;
    cin >> name1;

    cout << "Введите имя игрока 2: ";
    string name2;
    cin >> name2;

    Character player1(name1, 0, 100, 0);
    Character player2(name2, 0, 100, 0);

    bool game_over = false;
    bool turn = true;

    while (!game_over) {
        board.print(player1, player2);
        cout << "Ходит " << (turn ? player1.get_name() : player2.get_name()) << "\n";
        cout << "Введите команду:\n";
        cout << "1 - бросить кубик\n";
        cout << "2 - сохранить игру\n";
        cout << "3 - загрузить игру\n";
        cout << "4 - выйти из игры\n";

        int command = 0;
        string str;
        cin >> str;
        for (int i = 0; i < str.length(); i++)
        {
            if (str[i] < '0' || str[i] > '9')
            {
                command = -1;
            }
        }
        if (command == 0)
            command = stoi(str);
        int dice;
        switch (command) {
        case 1:
            dice = (turn ? player1.roll_dice() : player2.roll_dice());
            cout << "Кубик: " << dice << "\n";
            if (turn) {
                player1.move(dice);
                player1.check_bonus(board.get_bonuses());
                player1.apply_bonus(player2);
            }
            else {
                player2.move(dice);
                player2.check_bonus(board.get_bonuses());
                player2.apply_bonus(player1);
            }
            turn = !turn;
            break;
        case 2:
            board.save(player1, player2);
            break;
        case 3:
            if (board.load(player1, player2)) {
                turn = true;
            }
            break;
        case 4:
            game_over = true;
            break;
        default:
            cout << "Неверная команда!\n";
            break;
        }

        if (player1.get_position() == BOARD_SIZE - 1) {
            game_over = true;
            cout << player1.get_name() << " победил!\n";
        }
        else if (player2.get_position() == BOARD_SIZE - 1) {
            game_over = true;
            cout << player2.get_name() << " победил!\n";
        }
        else if (player1.get_health() == 0) {
            game_over = true;
            cout << player2.get_name() << " победил!\n";
        }
        else if (player2.get_health() == 0) {
            game_over = true;
            cout << player1.get_name() << " победил!\n";
        }
    }

    return 0; 
}
