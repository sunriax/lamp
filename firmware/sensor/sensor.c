
#include "sensor.h"

void sensor_init()
{
    // ADC Mode:
    // - Single conversion
    // - 10 Bit
    // - Right align
    adc_init();
}

unsigned char sensor_intensity()
{
    unsigned int value = adc_read();
    
    if(value < SENSOR_MIN_INTENSITY)
        value = SENSOR_MIN_INTENSITY;
    else if(value > SENSOR_MAX_INTENSITY)
        value = SENSOR_MAX_INTENSITY;
    
    return ((SENSOR_MAX_INTENSITY - value)>>5);
}