﻿interface Prototype_Counter
        if (cur < upper_limit)
        {
            val.step_up(1);
            return true;
        }
        else
        {
            return false;
        }         
        if (cur > 0)
        {
            val.step_down(1);
            return true;
        }
        else
        {
            return false;
        }
    }