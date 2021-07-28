
#ifndef MAIN_H_
#define MAIN_H_

#ifndef F_CPU
    #define F_CPU 16000000UL
#endif

#include <limits.h>
#include <avr/io.h>
#include <avr/interrupt.h>
#include <avr/eeprom.h>
#include <avr/sleep.h>
#include <util/delay.h>

#include "uart/uart.h"
#include "prom/prom.h"
#include "led/led.h"
#include "prom/prom.h"
#include "system/system.h"
#include "sensor/sensor.h"

void status_message(unsigned char config);
unsigned char validate_color(Level t, Color c);
unsigned char validate_range(unsigned int value, unsigned int min, unsigned int max);

#endif /* MAIN_H_ */