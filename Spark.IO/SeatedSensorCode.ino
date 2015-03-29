
int photocellPin1 = A0; // the cell and 10K pulldown are connected to a0
int photocellPin2 = A2; // the cell and 10K pulldown are connected to a0
double photocellReading1; // the analog reading from the sensor divider
double photocellReading2; // the analog reading from the sensor 
int sensor1 = 0;
int sensor2 = 0;
int LEDpin = 11; // connect Red LED to pin 11 (PWM pin)
int LEDbrightness; //
void setup(void) {
    
 Spark.variable("photocell", &sensor1, INT);
 Spark.variable("photocell2", &sensor2, INT);


}

void loop(void) {
photocellReading1 = analogRead(photocellPin1);
photocellReading2 = analogRead(photocellPin2);

if(photocellReading1 < 2000) 
{
    sensor1 = 1;
    
}
else {
    sensor1 = 0;
}


if (photocellReading2 > 2000) 
{
    
    sensor2 = 1;
    
}
else {
    sensor2 = 0;
}



delay(100);
}