using ManagementCompany;

Console.Title = "Management company";

Flat a = new Flat("Kotěhůlky 151");
Flat b = new Flat("U bobřích fousků 16");

a.newProblem("locksmith", "tinman");
b.newProblem("gardener", "bricklayer");



Management m = new Management(a, b);
m.newContact(new Contact("Matěj", "Kůzlátko", 588579985, Worker.Profession.locksmith, false));
m.newContact(new Contact("Samuel", "Skokánek", 457588241, Worker.Profession.tinman, true));
m.newContact(new Contact("Tomáš", "Huhlaví", 85551241, Worker.Profession.plumber, false));
m.newContact(new Contact("Sára", "Bobánková", 457588241, Worker.Profession.gardener, true));
m.newContact(new Contact("Klára", "Ramanová", 153258846, Worker.Profession.bricklayer, true));

Console.WriteLine(m.Solution());
Console.ReadKey();