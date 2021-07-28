/* -----------------------------------------
 * Liebherr Lehrlingsausbildung
 * www.liebherr.com
 * -----------------------------------------
 *    Hardware: Megacard (ATmega16)
 * -----------------------------------------
 *     Version: 1.0 Release
 *      Author: G.Raf
 * Description:
 *   Header file for led library
 * -----------------------------------------
 */

#ifndef LED_H_
#define LED_H_

#ifndef LED_ALPHA_MIN
    #define LED_ALPHA_MIN 1
#endif

#ifndef LED_ALPHA_MAX
    #define LED_ALPHA_MAX 31
#endif

#ifndef LED_COUNT
    #define LED_COUNT 7
#endif

#include "../spi/spi.h"
#include "../sensor/sensor.h"

struct Color_t
{
    volatile unsigned char R;
    volatile unsigned char G;
    volatile unsigned char B;
    volatile unsigned char Alpha;
    volatile unsigned char Time;
};

typedef struct Color_t Color;

void led_init();
void led_start();
void led_data(unsigned char red, unsigned char green,unsigned char blue, unsigned char alpha);
void led_stop();
void led_rgb(unsigned char red, unsigned char green,unsigned char blue, unsigned char alpha);
void led_color(Color color);
void led_clear();

#endif /* LED_H_ */