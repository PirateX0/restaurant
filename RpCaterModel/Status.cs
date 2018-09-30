namespace RpCater.Model
{
    public enum DeskStatus
    {
        Available,
        Busy
    }

    public enum HandleStatus
    {
        Insert,
        Update
    }

    public enum OrderStatus
    {
        Billed = 1,
        Checked = 2
    }

    public enum UseStatus
    {
        Use,
        DoNotUse,
        Error
    }

    public enum LoginStatus
    {
        OK,
        LoginNameIsNotFound,
        PasswordError
    }

    public enum DeleteStatus
    {
        Alive,
        Recyclable,
        Dead
    }
}