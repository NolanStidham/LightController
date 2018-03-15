#define REDPIN 5
#define GREENPIN 6
#define BLUEPIN 3

const uint8_t PROGMEM gamma8[] = {
    0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,
    0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  1,  1,  1,  1,
    1,  1,  1,  1,  1,  1,  1,  1,  1,  2,  2,  2,  2,  2,  2,  2,
    2,  3,  3,  3,  3,  3,  3,  3,  4,  4,  4,  4,  4,  5,  5,  5,
    5,  6,  6,  6,  6,  7,  7,  7,  7,  8,  8,  8,  9,  9,  9, 10,
   10, 10, 11, 11, 11, 12, 12, 13, 13, 13, 14, 14, 15, 15, 16, 16,
   17, 17, 18, 18, 19, 19, 20, 20, 21, 21, 22, 22, 23, 24, 24, 25,
   25, 26, 27, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36,
   37, 38, 39, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 50,
   51, 52, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 66, 67, 68,
   69, 70, 72, 73, 74, 75, 77, 78, 79, 81, 82, 83, 85, 86, 87, 89,
   90, 92, 93, 95, 96, 98, 99,101,102,104,105,107,109,110,112,114,
  115,117,119,120,122,124,126,127,129,131,133,135,137,138,140,142,
  144,146,148,150,152,154,156,158,160,162,164,167,169,171,173,175,
  177,180,182,184,186,189,191,193,196,198,200,203,205,208,210,213,
  215,218,220,222,224,227,230,232,235,238,241,244,245,246,247,248 };

int redValue, greenValue, blueValue, redTemp, greenTemp, blueTemp;
String readString;
String command;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(57600);
  pinMode(REDPIN, OUTPUT);
  pinMode(GREENPIN, OUTPUT);
  pinMode(BLUEPIN, OUTPUT);

  
}

void loop() {
  //Collect RGB values from desktop
  while(Serial.available()){
    char c = Serial.read();  //gets one byte from serial buffer
    readString += c; //makes the string readString
    delay(2);  //slow to allow buffer to fill with next character
  }//end of while

  //If the RGB values are complete, send the command to change the lights
  if(readString.length() == 9){
    command = readString;
    sendCommand(command);
    readString = "";
  }
}

void setColor(int r, int g, int b){
    analogWrite(REDPIN, r);
    analogWrite(GREENPIN, g);
    analogWrite(BLUEPIN, b);
  }

void sendCommand(String command){
    redValue = (int) command.substring(0, 3).toInt();
    greenTemp = (int) command.substring(3, 6).toInt();
    blueTemp = (int) command.substring(6).toInt();

    //redValue = pgm_read_byte(&gamma8[redTemp]);
    greenValue = pgm_read_byte(&gamma8[greenTemp]);
    blueValue = pgm_read_byte(&gamma8[blueTemp]);

    setColor(redValue, greenValue, blueValue);
  }
