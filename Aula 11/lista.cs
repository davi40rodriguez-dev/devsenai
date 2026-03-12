List <string> nomes = new List<string>();
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Clodoando");
nomes.Add("Maria");
foreach (var item in Range(0, nomes.Count))
{
    
    WriteLine(nomes[item]);
}