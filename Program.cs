Queue<string> Funcionarios = new Queue<string>();

int opr = 0;
while(opr != 2){
    Console.WriteLine("Adicione funcionários (Press '1') ou Liste funcionários e saia (Press '2')");
    opr = Convert.ToInt32(Console.ReadLine());
    if(opr == 1) addEmploy(Funcionarios);
    if(opr == 2) seeEmploy(Funcionarios);
}
void seeEmploy(Queue<string> Lista){
    foreach(string fun in Funcionarios)
        {Console.WriteLine(fun);}
        Console.WriteLine("------------");}
void addEmploy(Queue<string> Lista){
    int cargo = 0; string space = "";
    Console.Write("Digitar nome do funcionário: "); string funcio = Console.ReadLine() ?? "";
    Console.Write("Ranking de cargo do funcionário: "); cargo = Convert.ToInt32(Console.ReadLine());
    if(cargo-1>0){space = "    ";while(cargo-1>0){space+=space;cargo--;}}
    funcio=space+funcio;
    Lista.Enqueue(funcio);}
