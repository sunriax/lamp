/*
 * system.h
 *
 * Created: 07.07.2021 15:26:14
 *  Author: lwngar0
 */ 


#ifndef SYSTEM_H_
#define SYSTEM_H_

#ifndef LIGTH_SENSOR_CH
    #define LIGTH_SENSOR_CH 0
#endif

#ifndef SHDN_DDR
    #define SHDN_DDR  DDRB
#endif

#ifndef SHDN_PORT
    #define SHDN_PORT PORTB
#endif

#ifndef SHDN_PIN
    #define SHDN_PIN  PINB0
#endif

#ifndef CONTROL_DDR
    #define CONTROL_DDR   DDRD
#endif

#ifndef CONTROL_PORT
    #define CONTROL_PORT  PORTD
#endif

#ifndef CONTROL_PIN
    #define CONTROL_PIN   PIND
#endif

#ifndef SETUP_SWITCH
    #define SETUP_SWITCH  PIND2
#endif

#ifndef ENABLE_SWITCH
    #define ENABLE_SWITCH PIND3
#endif

#ifndef CODE_SWITCH
    #define CODE_SWITCH   0xF0
#endif

#include <avr/io.h>

void system_init();

void interrupt_init();
void interrupt_enable();
void interrupt_disable();
void timer_init();
void timer_enable();
void timer_disable();

unsigned char switch_status();
unsigned char enable_status();
unsigned char setup_status();

#endif /* SYSTEM_H_ */