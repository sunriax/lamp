/* -----------------------------------------
 * Liebherr Lehrlingsausbildung
 * www.liebherr.com
 * -----------------------------------------
 *    Hardware: Megacard (ATmega16)
 * -----------------------------------------
 *     Version: 1.0 Release
 *      Author: G.Raf
 * Description:
 *   Function file for led library
 * -----------------------------------------
 */

#include "led.h"

void led_init()
{
    // SPI Mode:
    // - Master
    // - MSB first
    // - Falling Polarity
    // - Rising Clock Phase
    spi_init(SPI_Master, SPI_MSB, SPI_Rising, SPI_Rising);
    sensor_init();
}

void led_start()
{
    // SOF
    for (unsigned char i=0; i < 4; i++)
    {
        spi_transfer(0x00);
    }
}

void led_data(unsigned char red, unsigned char green, unsigned char blue, unsigned char alpha)
{
    char temp = alpha - sensor_intensity();
    
    if(temp < 1)
        temp = 1;
    
    spi_transfer((0xE0 | (0x1F & temp)));
    spi_transfer(blue);
    spi_transfer(green);
    spi_transfer(red);
}

void led_stop()
{
    // EOF
    for (unsigned char i=0; i < 4; i++)
    {
        spi_transfer(0xFF);
    }
}

void led_rgb(unsigned char red, unsigned char green,unsigned char blue, unsigned char alpha)
{
    led_start();
    for (unsigned char i=0; i < LED_COUNT; i++)
    {
        led_data(red, green, blue, alpha);
    }
    led_stop();
}

void led_color(Color color)
{
    led_rgb(color.R, color.G, color.B, color.Alpha);
}

void led_clear()
{
    led_rgb(0, 0, 0, 0);
}