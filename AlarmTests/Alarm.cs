namespace SetAlarm
{
    class Alarm
    {
        public static bool SetAlarm(bool employed, bool vacation)
        {
            if ((employed == true) && (vacation == false))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
