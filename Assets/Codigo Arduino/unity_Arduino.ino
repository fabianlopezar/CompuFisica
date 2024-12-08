const int buttons[] = {A4, A3, A2, 5, 6, 7, 10, 11, 12}; // Pines de los botones
const int numButtons = 9;
bool buttonStates[numButtons]; // Guarda el estado anterior de cada botón

void setup() {
  Serial.begin(9600); // Inicia la comunicación serial a 9600 baudios
  for (int i = 0; i < numButtons; i++) {
    pinMode(buttons[i], INPUT_PULLUP); // Configura los botones como entradas con resistencia pull-up
    buttonStates[i] = HIGH; // Inicializa todos los botones como no presionados
  }
}

void loop() {
  for (int i = 0; i < numButtons; i++) {
    bool currentState = digitalRead(buttons[i]);
    if (buttonStates[i] == HIGH && currentState == LOW) { // Detecta si el botón se presionó
      Serial.println(i); // Envía el número del botón a Unity
      buttonStates[i] = LOW; // Actualiza el estado del botón como presionado
    } else if (buttonStates[i] == LOW && currentState == HIGH) { // Detecta si el botón se soltó
      buttonStates[i] = HIGH; // Actualiza el estado del botón como liberado
    }
  }
}

