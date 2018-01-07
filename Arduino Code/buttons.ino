//button.c

//pins numbers for all the buttons
const int buttonPin0 = 0; //Keyboard button w
const int buttonPin1 = 1; //a
const int buttonPin2 = 2; //s
const int buttonPin3 = 3; //d

// States for all the buttons
int buttonState0 = 0;
int buttonState1 = 0;
int buttonState2 = 0;
int buttonState3 = 0;

void setup() {
  pinMode(buttonPin0, INPUT); //Sets all of the buttons to receive input
  pinMode(buttonPin1, INPUT);
  pinMode(buttonPin2, INPUT);
  pinMode(buttonPin3, INPUT);
  Serial.begin(9600);
  Keyboard.begin();
}

void loop() {
  buttonState0 = digitalRead(buttonPin0); //States of being pressed of the buttons
  buttonState1 = digitalRead(buttonPin1);
  buttonState2 = digitalRead(buttonPin2);
  buttonState3 = digitalRead(buttonPin3);
  delay(100);

  //If any of the buttons are pressed down, a keyboard key is pressed down
  //until the button is released
  if (buttonState0 == HIGH) {
    Keyboard.press('w');
  }
  else {
    Keyboard.release('w');
  }
  
  if (buttonState1 == HIGH) {
    Keyboard.press('a');
  }
  else {
    Keyboard.release('a');
  }

  if (buttonState2 == HIGH) {
    Keyboard.press('s');
  }
  else {
    Keyboard.release('s');
  }

  if (buttonState3 == HIGH) {
    Keyboard.press('d');
  }
  else {
    Keyboard.release('d');
  }
}
