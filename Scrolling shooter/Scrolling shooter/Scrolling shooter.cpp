// Простая мини-игра на C++: скролл шутер
// Игрок управляет кораблем на экране, который постоянно стреляет
// Противники влезают в экран и игрок должен по ним попадать
// Игра заканчивается, когда игрок потеряет все жизни, или убьет всех противников, или противник дойдет до нижней линии


#include "Game.cpp"


// Функция для приостановки выполнения программы на заданное количество миллисекунд
void delay(int milliseconds) {
    clock_t start = clock();
    while (clock() - start < milliseconds);
}

int main() {
    Game game;
    int enemies = 0;
    while (!game.gameOver) {
        game.draw();

        int x = rand() % 2 + 1;;
        if (enemies + x <= ENEMY_COUNT)
        {
            enemies += x;
        }
        else
            x = 0;
        game.update(x);
        bool flag = 0;
        while (!flag)
        {

            if (_kbhit()) {
                // Считать код нажатой клавиши
                int code = _getch();

                // Сравнить код с кодами клавиш со стрелками и выполнить соответствующее действие
                switch (code) {
                case 72: 
                    game.player.moveVertical(-1); 
                    flag = 1;
                    break;
                case 75: 
                    game.player.moveHorizontal(-1); 
                    flag = 1;
                    break;
                case 80: 
                    game.player.moveVertical(1); 
                    flag = 1;
                    break;
                case 77: 
                    game.player.moveHorizontal(1); 
                    flag = 1;
                    break;
                default: 
                    break; 
                }

            }
        }
        delay(100);
    }
    game.draw();
    string end;
    cin >> end;
    return 0;
}
