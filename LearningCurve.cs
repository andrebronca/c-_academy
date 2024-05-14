using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //se não declarar o tipo, o padrão é: private
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAuthor = true;

    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";

    public string CharacterAction = "Attack";

    public int DiceRoll = 7;

    //declarando array
    int[] TopPlayerScores = new int[3];
    //long initializer
    int[] TopPlayerScores2 = new int[] {713, 549, 984};
    //shortcut initializer
    int[] TopPlayerScores3 = {713, 549, 984};

    //array bidimensional
    int[,] Coordinates = new int[3, 2];
    int[,] Coordinates2 = new int[3, 2]
    {
        {5,4},
        {1,7},
        {9,3}
    };

    int primeiro; // = Coordinates2[0, 1];  //4

    //criando listas
    List<string> QuestPartyMembers = new List<string>()
    {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the knight"
    };

    //criando dicionário (página 126)
    Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
    {
        {"Potion", 5 },
        {"Antidote", 7 },
        {"Aspirin", 1 }
    };

    //usar com while (página 135)
    public int PlayersLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        int CharacterLevel = 32;
        //Debug.log(30 + 1);
        //Debug.Log(CurrentAge + 1);
        ComputeAge();
        //string interpolada
        Debug.Log($"A string can have variable like {FirstName} and {Pi}, inserted directly!");

        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);
        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Faye", CharacterLevel));

        OpenTreasureChamber();

        PrintCharacterAction();

        RollDice();

        primeiro = Coordinates2[0, 1];
        Debug.LogFormat("party Members: {0}", QuestPartyMembers.Count);
        //adicionando um novo elemento
        QuestPartyMembers.Add("Craven the Necromancer");
        //adicionando em um ponto específico
        QuestPartyMembers.Insert(1, "Tanis the Thief");
        //removendo: por índice ou pelo valor literal
        QuestPartyMembers.RemoveAt(0);
        QuestPartyMembers.Remove("Tanis the Thief");

        Debug.LogFormat("Items: {0}", ItemInventory.Count);

        //recuperando um valor
        int numberOfPotions = ItemInventory["Potion"];
        //set um valor
        ItemInventory["Potion"] = 10;
        //adicionando nova chave-valor
        ItemInventory.Add("Throwing Knife", 3);
        //cria uma chave automaticamente se não existir
        ItemInventory["nova chave"] = 0;
        if (ItemInventory.ContainsKey("Correr"))
        {
            ItemInventory["Correr"] = 1;
        }
        //removendo uma chave-valor
        ItemInventory.Remove("nova chave");

        //percorrendo uma lista
        int listLength = QuestPartyMembers.Count;
        for(int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        }

        FindPartyMember();

        //percorrendo o dicionário
        foreach(KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }

        HealthStatus();

        //instanciando um objeto
        Character hero = new Character();
        hero.PrintStatsInfo();
        
        Character heroina = new Character("Josi");
        heroina.PrintStatsInfo();

        //usando struct
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();

        //demonstrando a passagem por referência de objeto
        Character villain = hero;
        villain.PrintStatsInfo();
        hero.PrintStatsInfo();
        villain.name = "Sir Kane the Bold";
        villain.PrintStatsInfo();
        hero.PrintStatsInfo();

        //passagem por valor de struct
        Weapon warBow = huntingBow;
        warBow.PrintWeaponStats();
        huntingBow.PrintWeaponStats();
        warBow.name = "War Bow";
        warBow.damage = 155;
        warBow.PrintWeaponStats();
        huntingBow.PrintWeaponStats();

        //chamando uma classe com herança
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();    //método herdado


    }

    public void HealthStatus()
    {
        while (PlayersLives > 0)
        {
            Debug.Log("Still alive!");
            PlayersLives--;
        }
        Debug.Log("Player KO'd...");
    }

    public void FindPartyMember()
    {
        List<string> QuestPartyMembers2 = new List<string>()
            {"Grim the Barbarian", "Merlin the Wise", "Sterling the knight"};

        int listLength = QuestPartyMembers2.Count;
        QuestPartyMembers2.Add("Craven the Necromancer");
        QuestPartyMembers2.Insert(1, "Tanis the Thief");
        QuestPartyMembers2.RemoveAt(0);

        Debug.LogFormat("Party Members: {0}", listLength);
        //usando o for tradicional
        for(int i = 0; i < listLength;  ++i)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers2[i]);

            if(QuestPartyMembers2[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
        }

        //usando foreach
        foreach (string partyMember in QuestPartyMembers2)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }
    }


    /// <summary>
    /// Tempo para ação.
    /// testando métodos
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
        Debug.LogFormat("Idade atual {0}, adicionar à idade {1}", CurrentAge, AddedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
        //Debug.Log($"Character: {name} - Level: {level}");
        return level += 5;
    }

    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not he knowledge.");
            } 
            else
            {
                Debug.Log("The treasure is yours, worthy hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
    }

    public void PrintCharacterAction()
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }

    public void RollDice()
    {
        switch(DiceRoll)
        {
            case 7:
            case 15:
                Debug.Log("Mediocre damage, not bad.");
                break;
            case 20:
                Debug.Log("Critical hit, the creature goes down!");
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
