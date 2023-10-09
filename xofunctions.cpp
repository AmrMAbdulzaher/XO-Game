#include <iostream>

#ifdef _WIN32
#define CLEAR "cls"
#else
#define CLEAR "clear"
#endif

using namespace std;
char A[3][3] = {{'1', '2', '3'}, {'4', '5', '6'}, {'7', '8', '9'}};
char choice = 'X';
void field() {
  int i, j;
  system(CLEAR); // Clear console
  cout << "XO Game v1.0 \t"
       << "By Amr Mohamed Abdelzaher" << endl;
  for (i = 0; i < 3; i++) {
    for (j = 0; j < 3; j++) {
      cout << " " << A[i][j] << " ";
    }
    cout << endl << endl;
  }
}

// Choosing the position of the move.
void input() {
  int ps;
  cout << "Choose your position, Player " << choice << ": ";
  cin >> ps;
  if (ps >= 1 && ps <= 9) {
    int row = (ps - 1) / 3;
    int col = (ps - 1) % 3;

    if (A[row][col] == 'X' || A[row][col] == 'O') {
      cout << "This one is used. Choose another position.\n";
      input();
    } else {
      A[row][col] = choice;
    }
  } else {
    cout << "Invalid position. Choose a number between 1 and 9.\n";
    input();
  }
}

// Winner Detector
char WinDtcr() {
  // Check rows
  for (int i = 0; i < 3; i++) {
    if (A[i][0] == A[i][1] && A[i][1] == A[i][2]) {
      return A[i][0];
    }
  }

  // Check columns
  for (int i = 0; i < 3; i++) {
    if (A[0][i] == A[1][i] && A[1][i] == A[2][i]) {
      return A[0][i];
    }
  }

  // Check diagonals
  if (A[0][0] == A[1][1] && A[1][1] == A[2][2]) {
    return A[0][0];
  }
  if (A[0][2] == A[1][1] && A[1][1] == A[2][0]) {
    return A[0][2];
  }

  // No winner
  return ' ';
}
