#include "darts.h"

float distance_squared(coordinate_t landing_position)
{
    return landing_position.x * landing_position.x + landing_position.y * landing_position.y;
}

int score(coordinate_t landing_position)
{
    if (distance_squared(landing_position) <= 1.0F)
        return 10;
    if (distance_squared(landing_position) <= 25.0F)
        return 5;
    if (distance_squared(landing_position) <= 100.0F)
        return 1;
    else
        return 0;
}
