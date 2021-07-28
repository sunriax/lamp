
#include "system.h"

void system_init()
{
    // PORT initialization
    SHDN_DDR |= (1<<SHDN_PIN);
    
    // PULLUP initialization
    CONTROL_PORT |= CODE_SWITCH | (1<<ENABLE_SWITCH) | (1<<SETUP_SWITCH);
    
    // Enable Shelly
    SHDN_PORT |= (1<<SHDN_PIN);
    
    interrupt_init();
    timer_init();
}

void interrupt_init()
{
    // External Interrupt 1
    // Mode: Low Level interrupt
    MCUCR &= ~((1<<ISC11) | (1<<ISC10));
    GICR |= (1<<INT1);
}

void interrupt_enable()
{
    GIFR |= (1<<INTF1);
    GICR |= (1<<INT1);
}

void interrupt_disable()
{
    GICR &= ~(1<<INT1);
    GIFR |= (1<<INTF1);
}

void timer_init()
{
    // Timer 1
    //      Mode: CTC
    // Prescaler: 1024
    //         T: 1s
    
    TCCR1B = (1<<WGM12) | (1<<CS12) | (1<<CS10);
    OCR1A = 15624;
    
    TIMSK |= (1<<OCIE1A);
}

void timer_enable()
{
    TCCR1B |= (1<<CS12) | (1<<CS10);
    TCNT1 = 0;
}

void timer_disable()
{
    TCCR1B &= ~((1<<CS12) | (1<<CS10));
    TCNT1 = 0;
}

unsigned char switch_status()
{
    return 0x0F & ~((0x08 & (CONTROL_PIN>>4)) | (0x04 & (CONTROL_PIN>>2)) | (0x02 & (CONTROL_PIN>>5)) | (0x01 & (CONTROL_PIN>>5)));
}

unsigned char enable_status()
{
    return !(CONTROL_PIN & (1<<ENABLE_SWITCH));
}

unsigned char setup_status()
{
    return !(CONTROL_PIN & (1<<SETUP_SWITCH));
}