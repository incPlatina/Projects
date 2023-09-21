
#include "Player.cpp"
#include "Enemy.cpp"
#include "Bullet.cpp"
#include "GameObject.cpp"
// ����� ��� ������������� ����
class Game {
public:
    Player player;
    vector<Enemy> enemies;
    vector<Bullet> bullets;
    bool gameOver;

    // ����������� �� ���������
    Game() : player(SCREEN_WIDTH / 2, SCREEN_HEIGHT - 1, 'A', "green", 3) {
        srand(time(NULL));
        gameOver = false;
    }

    // ����� ��� ��������� ���� �� ������
    void draw() {
        // �������� �����
        system("cls");

        // ������� ��������� ������ �������� ��� ����������� ����
        char screen[SCREEN_HEIGHT][SCREEN_WIDTH];

        // ��������� ������ ���������
        for (int y = 0; y < SCREEN_HEIGHT; y++) {
            for (int x = 0; x < SCREEN_WIDTH; x++) {
                screen[y][x] = ' ';
            }
        }

        // ��������� ������� ������, ����������� � ���� � ������
        screen[player.y][player.x] = player.symbol;
        for (Enemy& enemy : enemies) {
            screen[enemy.y][enemy.x] = enemy.symbol;
        }
        for (Bullet& bullet : bullets) {
            screen[bullet.y][bullet.x] = bullet.symbol;
        }

        // ������� ������ �� ����� � �������

        for (int y = 0; y < SCREEN_HEIGHT; y++) {
            for (int x = 0; x < SCREEN_WIDTH; x++) {
                char symbol = screen[y][x];
                if (symbol == player.symbol) {
                    cout << "\033[32m" << symbol << "\033[0m"; // ������� ���� ��� ������
                }
                else if (!enemies.empty() && symbol == enemies[0].symbol) {
                    cout << "\033[31m" << symbol << "\033[0m"; // ������� ���� ��� �����������
                }
                else if (!bullets.empty() && symbol == bullets[0].symbol) {
                    cout << "\033[33m" << symbol << "\033[0m"; // ������ ���� ��� ����
                }
                else {
                    cout << symbol;
                }
            }
            cout << endl;
        }

        // ������� ���������� �� ����: �����, ���������� ����������� � ��������� �� ��������� ����
        cout << "Lives: " << player.lives << endl;
        cout << "Enemies: " << enemies.size() << endl;
        if (gameOver) {
            if (player.lives > 0 && enemies.empty()) {
                cout << "You win!" << endl;
            }
            else {
                cout << "You lose!" << endl;
            }
            cout << "Press any key to exit." << endl;
        }
    }

    // ����� ��� ���������� ������ ����
    void update(int x) {
        if (gameOver) return;

        for (int i = 0; i < x; i++) {
            int x = rand() % SCREEN_WIDTH;
            int y = 0;
            //int speed = rand() % 3 + 1; // ��������� �������� �� 1 �� 3
            enemies.push_back(Enemy(x, y, 'X', "red", 1));
        }

        // �������� ��������� ���� � ��������� ������������ � ������������ � ������
        for (int i = 0; i < bullets.size(); i++) {
            Bullet& bullet = bullets[i];
            bullet.update();
            bool hit = false;
            for (int j = 0; j < enemies.size(); j++) {
                Enemy& enemy = enemies[j];
                if (bullet.y <= enemy.y && bullet.x == enemy.x) {
                    hit = true;
                    enemies.erase(enemies.begin() + j);
                    break;
                }
            }
            if (hit || bullet.y < 0) {
                bullets.erase(bullets.begin() + i);
                i--;
            }
        }

        // �������� ��������� ����������� � ��������� ������������ � ������� � ���������
        for (int i = 0; i < enemies.size(); i++) {
            Enemy& enemy = enemies[i];
            enemy.update();
            if (enemy.collideWith(player)) {
                player.lives--;
                enemies.erase(enemies.begin() + i);
                i--;
            }
            else if (enemy.y == SCREEN_HEIGHT - 1) {
                gameOver = true;
                break;
            }
        }

        // ������� ����� ���� � ������� ������ � �������� ���������
        bullets.push_back(Bullet(player.x, player.y, '|', "yellow", -5));

        // ��������� ������� ��������� ����: ���� ����� ������� ��� �����, ���� ���� ���� �����������
        if (player.lives <= 0 || enemies.empty()) {
            gameOver = true;
        }
    }
};