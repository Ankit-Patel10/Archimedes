//button.c
//#include "Keyboard.h"

//Keyboard keycode constants recognized by the computer (in decimal form)
//Variable name is the letter of the key
#define J_KEY 13
#define K_KEY 14
#define D_KEY 7
#define A_KEY 4
#define L_KEY 15

uint8_t buff[8] = {0}; //Keyboard report buffer

//Pins numbers for all the buttons and the colour of the buttons are the var names
const int blue = 2;
const int red = 3;
const int right = 4;
const int left = 5;
const int yellow = 6;

//States for all the buttons
int blueState = 0;
int redState = 0;
int rightState = 0;
int leftState = 0;
int yellowState = 0;

void setup() {
  pinMode(blue, INPUT); //Sets all of the buttons to receive input
  pinMode(red, INPUT);
  pinMode(right, INPUT);
  pinMode(left, INPUT);
  pinMode(yellow, INPUT);
  Serial.begin(9600);
  //Keyboard.begin();
}

void loop() {
  blueState = digitalRead(blue); //States of being pressed of the buttons
  redState = digitalRead(red);
  rightState = digitalRead(right);
  leftState = digitalRead(left);
  yellowState = digitalRead(yellow);
  delay(10);

  //If any of the buttons are pressed down, a keyboard key is pressed down
  //until the button is released
  
  if (blueState == HIGH) {
    buff[2] = J_KEY;
    Serial.write(buff, 8);
    releaseKey();
  }
  
  if (redState == HIGH) {
    buff[2] = K_KEY;
    Serial.write(buff, 8);
    releaseKey();
  }
  
  if (rightState == HIGH) {
    buff[2] = D_KEY;
    Serial.write(buff, 8);
    releaseKey();
  }
  
  if (leftState == HIGH) {
    buff[2] = A_KEY;
    Serial.write(buff, 8);
    releaseKey();
  }

  if (yellowState == HIGH) {
    buff[2] = L_KEY;
    Serial.write(buff, 8);
    releaseKey();
  }
}

//Releases all keys of being pressed
void releaseKey(){
  buff[0] = 0;
  buff[2] = 0;
  Serial.write(buff, 8);
}

