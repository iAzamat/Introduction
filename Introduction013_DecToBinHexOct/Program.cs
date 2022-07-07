static void DectoBin(int a)
{
    int b;
    int c = a;
    String temp = "";
    while (a != 0)
    {
        b = a % 2;
        temp = b + temp;
        a = a / 2;
    }
    Console.Write(c + " => " + temp + "\n");
}

static void DectoOct(int a)
{
    int b;
    int c = a;
    String temp = "";
    while (a != 0)
    {
        b = a % 8;
        temp = b + temp;
        a = a / 8;
    }
    Console.Write(c + " => " + temp + "\n");
}

static void DectoHex(int a)
{
    int b;
    int c = a;
    String hex = "";
    String temp = "";
    while (a != 0)
    {
        b = a % 16;
        if (b == 10) { hex = "A"; };
        if (b == 11) { hex = "B"; };
        if (b == 12) { hex = "C"; };
        if (b == 13) { hex = "D"; };
        if (b == 14) { hex = "E"; };
        if (b == 15) { hex = "F"; };
        if (b >= 0 && b <= 9) { hex = b.ToString(); };
        temp = hex + temp;
        a = a / 16;
    }
    Console.Write(c + " => " + temp + "\n");
}

    DectoBin(999);
    DectoHex(999);
    DectoOct(999);




