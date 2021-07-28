

#ifndef PROM_H_
#define PROM_H_

enum Level_t
{
    Info=0,
    Warn=1,
    Fail=2
};

typedef enum Level_t Level;

#ifndef PROM_MAX_INFO_LEVEL
    #define PROM_MAX_INFO_LEVEL 100
#endif

#ifndef PROM_MAX_WARN_LEVEL
    #define PROM_MAX_WARN_LEVEL 200
#endif

#ifndef PROM_MAX_FAIL_LEVEL
    #define PROM_MAX_FAIL_LEVEL 255
#endif

#include <avr/eeprom.h>
#include "../led/led.h"

char* prom_version();
void prom_setup_color(Level level, Color color);
Color prom_color(Level level);

#endif /* PROM_H_ */