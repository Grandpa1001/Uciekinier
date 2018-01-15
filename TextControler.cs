using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // trzeba dodać za każdym razem gdy używamy UI
using UnityEngine;

public class TextControler : MonoBehaviour {

    public Text text;
    enum States {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
        corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2, corridor_2, courtyard, corridor_3
    };
    private States myState;


	// Use this for initialization
	void Start () {
        myState = States.cell;

	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if      (myState == States.cell)        {cell();}
        else if (myState == States.sheets_0)    {sheets_0();}
        else if (myState == States.mirror)      {mirror();}
        else if (myState == States.lock_0)      {lock_0();}
        else if (myState == States.cell_mirror) {cell_mirror();}
        else if (myState == States.sheets_1)    {sheets_1();}
        else if (myState == States.lock_1)      {lock_1();}
        else if (myState == States.corridor_0)  {corridor_0();}
        else if (myState == States.stairs_0)    {stairs_0();}
        else if (myState == States.floor)       {floor();}
        else if (myState == States.closet_door) {closet_door();}
        else if (myState == States.stairs_1)    {stairs_1();}
        else if (myState == States.corridor_1)  {corridor_1();}
        else if (myState == States.in_closet)   {in_closet();}
        else if (myState == States.stairs_2)    {stairs_2();}
        else if (myState == States.corridor_2)  {corridor_2();}
        else if (myState == States.courtyard)   {courtyard();}
        else if (myState == States.corridor_3)  {corridor_3();}


    }
    #region State handler methods
    void cell()
    {
        text.text = "Jesteś wieźniem w celi, i chcesz z niej uciec. Widzisz " +
            "jakąś brudną koszulkę na lóżku, lustro na ścianie i drzwi " + // \n new line
            "które są zamknięte od zewnątrz .\n\n\n" +
            "Kliknij S by spojrzeć na koszulkę, M by sprawdzić Lustro i L by sprawdzić drzwi.";

        if      (Input.GetKeyDown(KeyCode.S))   {myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.M))   {myState = States.mirror;}
        else if (Input.GetKeyDown(KeyCode.L))   {myState = States.lock_0;}}

    void sheets_0(){
        text.text = "Nie moźesz uwierzyć, że przed chwilą jeszcze w niej spałeś. " +
                    "Pora chyba by ją zmienić. Przyjemność bycia wieźniem, " + // \n new line
                    "Tak myślę! \n\n\n" +
                    "Kliknij R by rozejrzec się po celi";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.cell;}
    }
    void mirror() {
        text.text = "Przepiękne lustro w odróżnieniu od twarzy którą w niej widzisz." +
                    "Wygląda na uszkodzone, jeżeli delikatnie je przesuniesz,  " + // \n new line
                    "będziesz w stanie wziąć kawałek. \n\n\n" +
                    "Kliknij T by wziąć kawałek szkła lub R by rozejrzeć się po celi";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.cell;}
        else if (Input.GetKeyDown(KeyCode.T))   {myState = States.cell_mirror;}
    }
    void lock_0() {
        text.text = "Zamek w drzwiach nie wygladą na cud techniki,  " +
                    "gdybym tylko miał coś czym mógłbym " + // \n new line
                    "przekręcić zamek i wydostać się stąd. \n\n"+
                    "Kliknij R by rozejrzec się po celi ";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.cell;} 
    }
    void cell_mirror() {
        text.text = "Jesteś więźniem w celi, i chcesz z niej uciec. Widzisz " +
                    "jakąś brudną koszulkę na łóżku, masz kawalek lustra w ręce i drzwi " + // \n new line
                    "które są zamknięte od zewnątrz. \n\n\n" +
                    "Kliknij S by spojrzeć na koszulkę lub L by sprawdzić drzwi.";

        if      (Input.GetKeyDown(KeyCode.S))   {myState = States.sheets_1;}
        else if (Input.GetKeyDown(KeyCode.L))   {myState = States.lock_1; }
    }

    void sheets_1() {
        text.text = "Ta koszulka nadal nie wygląda zachęcająco, " +
                    "wątpie by mi się do czegoś przydała. " + // \n new line
                    "Tak myslę. \n\n" +
                    "Kliknij R by rozejrzeć sie po celi";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.cell_mirror;}
    }

    void lock_1() {
        text.text = "Ten kawałek lustra powinien się nadawać,  " +
                    "wystarczy tylko troche przekręcić,  " + // \n new line
                    "i powinienem być wolny! \n\n" +
                    "Kliknij R by wóocić do celi lub  O by otworzyć ";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.cell_mirror;}
        else if (Input.GetKeyDown(KeyCode.O))   {myState = States.corridor_0;}
    }

    void corridor_0()
    {
        text.text = "Jesteś na korytarzu,  " +
                    
                    "Gratulacje udało ci się uciec ! \n\n\n\n" +
                    "Widzisz schody, na podłodze coś leży, oraz przed sobą masz zamknięte drzwi \n\n\n"+
                    "Kliknij S by sprawdzić schody, F podłogę, C zamknięte drzwi";

        if      (Input.GetKeyDown(KeyCode.S))   {myState = States.stairs_0;}
        else if (Input.GetKeyDown(KeyCode.F))   {myState = States.floor;}
        else if (Input.GetKeyDown(KeyCode.C))   {myState = States.closet_door;}
    }
    void stairs_0(){
        text.text = "Wchodzisz po schodach które wydają okropny hałas,  " +
                    "wydaje mi się, że nie ma sensu się tam pakować,  " +
                    "Niechcesz dać się znów złapać ! \n\n\n\n" +
                    "Kliknij R by wrócić na korytarz ";

        if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_0;}
    }
    void closet_door(){
        text.text = "Zamknięte drzwi, nic nadzwyczajnego.  " +
                    "Wyglądają jak drzwi od przedpokoju,  " +
                    "Tylko jak je otworzyć?  \n\n\n\n" +
                    "Kliknij R by wrócić na korytarz ";

        if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_0;}
    }
    void floor(){
        text.text = "Przyglądasz się jakieś dziwnej rzeczy na podłodzę.  " +
                    "Wygląda na jakiś metalowe.... coś.  " +
                    "Zaraz przecież to spinka do włosów, może się przydać.  \n\n\n\n" +
                    "Kliknij H by podnieść spinkę, R by rozejrzeć się po korytarzu ";

        if          (Input.GetKeyDown(KeyCode.H)) {myState = States.corridor_1;}
        else if     (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_0;}
    }
    void corridor_1(){
        text.text = "Korytarz, ty ze spinką w ręce, ciekawe gdzie się teraz udasz?  " +
                    "Pamiętaj, że spinka do schodów ci się nie przyda.  " +
                    "Poprostu wyprzedzam twoje pomysły!  \n\n\n\n" +
                    "Kliknij S by wejść po schodach, P by spróbować otworzyć zamknięte drzwi ";

        if      (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_1;}
        else if (Input.GetKeyDown(KeyCode.P)) {myState = States.in_closet;}
    }
    void stairs_1(){
        text.text = "No gratuluje pomysłowości. " +
                    "Jak ty w ten sposób chcesz uciekać to lepiej posłuchaj mnie. " +
                    "Tą spinką otworzysz drzwi!  \n\n\n\n" +
                    "Kliknij R by wrócić na korytarz ";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.corridor_1;}
    }
    void in_closet(){
        text.text = "Udało się otworzyć drzwi. " +
                    "No i proszę schowek a w nim ubranie sprzątacza. " +
                    "W tym stroju był byś w stanie nabrać każdego. \n\n\n\n" +
                    "Kliknij D by się przebrać, R by wrócić na korytarz ";

        if      (Input.GetKeyDown(KeyCode.D))   {myState = States.corridor_3;}
        else if (Input.GetKeyDown(KeyCode.R))   {myState = States.corridor_2;}
    
    }
    void corridor_2(){
        text.text = "Korytarz nic się już tu chyba dla mnie nie zmieni, " +
                    "bez przebrania zostanę rozpoznany. Nie posiadam już  " +
                    "nawet mojej spinki. \n\n\n\n" +
                    "Kliknij B by wrócić do schowka, S by wejść po schodach ";

        if      (Input.GetKeyDown(KeyCode.B))   {myState = States.in_closet;}
        else if (Input.GetKeyDown(KeyCode.S))   {myState = States.stairs_2;}

    }
    void stairs_2(){
        text.text = "Poraz kolejny twoja upartość mnie zadziwia. A już myślałem " +
                    ", że nie jesteś w wstanie mnie zdziwić. Nie udasz się tam  " +
                    "ubrany w ten sposób! \n\n\n\n" +
                    "Kliknij R by wrócić na korytarz ";

        if      (Input.GetKeyDown(KeyCode.R))   {myState = States.corridor_2;}
    }
    void corridor_3(){
        text.text = "No proszę bardzo, rzec by się chciało, że dotwarzy ci w tym wdzianku. " +
                    "Przebrany za sprzątacza jesteś w stanie przemknąć się po schodach. \n\n\n\n" +
                    "Kliknij S by wejść po schodach, U by przebrać się z powrotem ";

        if (Input.GetKeyDown(KeyCode.S)) { myState = States.courtyard; }
        else if (Input.GetKeyDown(KeyCode.U)) { myState = States.in_closet; }

    }
    void courtyard(){
        text.text = "Udało się jesteś na dziedzińcu, " +
                    "pora zacząć cieszyć się wolnością!\n\n  " +
                    "Gratulacje jesteś wolny ! \n\n\n\n" +
                    "Kliknij R by zagrać ponownie ";

        if (Input.GetKeyDown(KeyCode.R)) { myState = States.cell; }
    }
#endregion State

}

