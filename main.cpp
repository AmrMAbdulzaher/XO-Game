#include <iostream>
#include "xofunctions.h"
using namespace std;
extern char choice;
int main()
{
    int n = 0;
    field();
    while (1)
    {
        n++;
        input();
        field();
        char winner = WinDtcr();
        if (winner == 'X')
        {
            cout << "The Winner is Player X!" << endl;
            break;
        }
        else if (winner == 'O')
        {
            cout << "The Winner is Player O!" << endl;
            break;
        }
        else if (winner == ' ' && n == 9)
        {
            cout << "No one wins, it's a draw!" << endl;
            break;
        }
        choice = (choice == 'X') ? 'O' : 'X';
    }
    cout << "Press enter to exit.";
    cin.ignore(); // Ignore the newline character
    cin.get(); // Wait for user to press enter
    return 0;
}
