
#ifndef SENSOR_H_
#define SENSOR_H_

#ifndef SENSOR_MIN_INTENSITY
    #define SENSOR_MIN_INTENSITY 300
#endif

#ifndef SENSOR_MAX_INTENSITY
    #define SENSOR_MAX_INTENSITY 700
#endif

#include "../adc/adc.h"

void sensor_init();
unsigned char sensor_intensity();

#endif /* SENSOR_H_ */