
#include "prom.h"

EEMEM char VERSION[] = "1.0.0";
char buffer[sizeof(VERSION)];

EEMEM Color LEVEL_INFO_LEDS = { 0x00, 0xFF, 0x00, 0x0F, 0x0A};
EEMEM Color LEVEL_WARN_LEDS = { 0xFF, 0xFF, 0x00, 0x0F, 0x14};
EEMEM Color LEVEL_FAIL_LEDS = { 0xFF, 0x00, 0x00, 0x0F, 0x00};

char* prom_version()
{
    eeprom_read_block(buffer, VERSION, sizeof(VERSION));
    return buffer;
}

void prom_setup_color(Level level, Color color)
{
    switch (level)
    {
        case Info:
            eeprom_update_block(&color, &LEVEL_INFO_LEDS, sizeof(Color));
        break;
        case Warn:
            eeprom_update_block(&color, &LEVEL_WARN_LEDS, sizeof(Color));
        break;
        case Fail:
            eeprom_update_block(&color, &LEVEL_FAIL_LEDS, sizeof(Color));
        break;
    }
}

Color prom_color(Level level)
{
    Color color;
    
    switch (level)
    {
        case Info:
            eeprom_read_block(&color, &LEVEL_INFO_LEDS, sizeof(Color));
        break;
        case Warn:
            eeprom_read_block(&color, &LEVEL_WARN_LEDS, sizeof(Color));
        break;
        default:
            eeprom_read_block(&color, &LEVEL_FAIL_LEDS, sizeof(Color));
        break;
    }
    
    return color;
}


