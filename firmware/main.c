
#include "main.h"

volatile Color color;
volatile unsigned char tick;

ISR(INT1_vect)
{
    cli();
    interrupt_disable();
    sei();
}

ISR(TIMER1_COMPA_vect)
{
    if(tick < prom_color(Info).Time)
    {
        color = prom_color(Info);
        tick++;
    }
    else if(tick < prom_color(Warn).Time)
    {
        color = prom_color(Warn);
        tick++;
    }
    else
    {
        color = prom_color(Fail);
        timer_disable();
    }
}

int main(void)
{
    // SYSTEM Mode:
    // - External Interrupt 1
    // - Timer 1
    system_init();
    
    // UART Mode:
    // - 9600@8N1
    uart_init();
    
    led_init();
    
    if(setup_status())
    {
        status_message(1);
        
        char command = '\0';
        
        do
        {
            unsigned char temp;
            Color c;
            
            if(scanf("[%hhu:%hhu,%hhu,%hhu,%hhu,%hhu]", &temp, &c.R, &c.G, &c.B, &c.Alpha, &c.Time) == 6)
            {
                Level l = temp;
                
                if(!validate_color(l, c))
                continue;
                
                prom_setup_color(l, c);
                led_color(c);
            }
            else
            {
                if(scanf("%c", &command) != 1)
                uart_clear();
            }
        } while (command != 'q');
    }
    
    led_rgb(255, 0, 0, 0x0F);
    _delay_ms(1000);
    led_rgb(0, 0, 255, 0x0F);
    _delay_ms(1000);
    led_rgb(0, 255, 0, 0x0F);
    _delay_ms(1000);
    
    status_message(0);
    sei();
    
    unsigned char init_run = 1;
    
    while (1)
    {
        if(enable_status())
        {
            _delay_ms(10);
            
            if(init_run)
            {
                status_message(0);
                init_run = 0;
            }
            
            // Code switch (Gray Code)
            switch (switch_status())
            {
                case 0b0000:
                    led_color(color);
                    _delay_ms(1000);
                    led_clear();
                    _delay_ms(1000);
                break;
                case 0b0001:
                    led_color(color);
                    _delay_ms(500);
                    led_clear();
                    _delay_ms(500);
                break;
                case 0b0011:
                    led_color(color);
                    _delay_ms(250);
                    led_clear();
                    _delay_ms(250);
                break;
                case 0b0010:
                    led_color(color);
                    _delay_ms(100);
                    led_clear();
                    _delay_ms(100);
                break;
                case 0b0110:
                    color.R++;
                    color.G++;
                    color.B++;
                    led_color(color);
                    _delay_ms(50);
                break;
                case 0b0111:
                    color.R++;
                    color.G++;
                    color.B--;
                    led_color(color);
                    _delay_ms(50);
                break;
                case 0b0101:
                    color.R++;
                    color.G--;
                    color.B--;
                    led_color(color);
                    _delay_ms(50);
                break;
                case 0b0100:
                    color.R--;
                    color.G--;
                    color.B--;
                    led_color(color);
                    _delay_ms(50);
                break;
                case 0b1100:
                    color.R++;
                    color.G--;
                    color.B++;
                    led_color(color);
                    _delay_ms(50);
                break;
                default:
                    led_color(color);
                break;
            }
        }
        else
        {
            _delay_ms(10);
            
            led_clear();
            status_message(0);
            
            init_run = 1;
            
            if(!enable_status())
            {
                interrupt_enable();
                
                // Start sleep mode
                // Exit: INT1 occurrs
                set_sleep_mode(SLEEP_MODE_PWR_DOWN);
                sleep_enable();
                sei();
                sleep_cpu();
                sleep_disable();
                
                color.R = 0x00;
                color.G = 0x00;
                color.B = 0x00;
                
                tick = 0;
                timer_enable();
            }
        }
    }
}

void status_message(unsigned char config)
{
    Color c;
    
    printf("{");
    printf("\"Version\":\"%s\",", prom_version());
    if(enable_status())
        printf("\"Status\":true,");
    else
        printf("\"Status\":false,");
        
    if(config)
        printf("\"Config\":true,");
    else
        printf("\"Config\":false,");
    printf("\"Mode\":[");
    
    c = prom_color(Info);
    printf("{\"Level\":%u,\"R\":%u,\"G\":%u,\"B\":%u,\"A\":%u,\"Time\":%u},", Info, c.R, c.G, c.B, c.Alpha, c.Time);
    
    c = prom_color(Warn);
    printf("{\"Level\":%u,\"R\":%u,\"G\":%u,\"B\":%u,\"A\":%u,\"Time\":%u},", Warn, c.R, c.G, c.B, c.Alpha, c.Time);
    
    c = prom_color(Fail);
    printf("{\"Level\":%u,\"R\":%u,\"G\":%u,\"B\":%u,\"A\":%u,\"Time\":%u}", Fail, c.R, c.G, c.B, c.Alpha, c.Time);
    printf("],");
    printf("\"Switch\":%u,", switch_status());
    printf("\"Sensor\":%u", sensor_intensity());
    printf("}\r\n");
    
    _delay_ms(1000);
}

unsigned char validate_color(Level l, Color c)
{
    if(!validate_range(c.Alpha, LED_ALPHA_MIN , LED_ALPHA_MAX))
        return 0;
    
    switch (l)
    {
        case Info:
            if(!validate_range(c.Time, 1, PROM_MAX_INFO_LEVEL))
                return 0;
        case Warn:
            if(!validate_range(c.Time, 1, PROM_MAX_WARN_LEVEL))
                return 0;
        default:
            return 1;
    }
    return 1;
}

unsigned char validate_range(unsigned int value, unsigned int min, unsigned int max)
{
    if(value >= min && value <= max)
        return 1;
    return 0;
}