using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // trzeba dodać za każdym razem gdy używamy UI
using UnityEngine;

public class TextControler : MonoBehaviour {

    public Text text;
    enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
    private States myState;


	// Use this for initialization
	void Start () {
        myState = States.cell;

	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell) {
            state_cell();
        } else if (myState == States.sheets_0) {
            state_sheets_0();
        } else if (myState == States.mirror) {
            state_mirror();
        } else if (myState == States.lock_0) {
            state_lock_0();
        } else if (myState == States.cell_mirror) {
            state_cell_mirror();
        } else if (myState == States.sheets_1) {
            state_sheets_1();
        } else if (myState == States.lock_1) {
            state_lock_1();
        } else if (myState == States.freedom) {
            state_freedom();
        }
    }
    void state_cell()
    {
        text.text = "Jesteś wieźniem w celi, i chcesz z niej uciec. Widzisz " +
            "jakąś brudną koszulkę na lóżku, lustro na ścianie i drzwi " + // \n new line
            "które są zamknięte od zewnątrz .\n\n\n" +
            "Kliknij S by spojrzeć na koszulkę, M by sprawdzić Lustro i L by sprawdzić drzwi.";
        if (Input.GetKeyDown(KeyCode.S)){
            myState = States.sheets_0;
        } else if (Input.GetKeyDown(KeyCode.M)){
            myState = States.mirror;
        } else if (Input.GetKeyDown(KeyCode.L)){
            myState = States.lock_0;
        }
    }
    void state_sheets_0(){
        text.text = "Nie moźesz uwierzyć, że przed chwilą jeszcze w niej spałeś. " +
                    "Pora chyba by ją zmienić. Przyjemność bycia wieźniem, " + // \n new line
                    "Tak myślę! \n\n\n" +
                    "Kliknij R by rozejrzec się po celi";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void state_mirror() {
        text.text = "Przepiękne lustro w odrużnieniu od twarzy ktora w niej widzisz " +
                    "wygląda na uszkodzone, jeżeli delikatnie je odsuniesz " + // \n new line
                    "bedziesz w stanie wziąć kawałek \n\n\n" +
                    "Kliknij T by wziąć kawałek szkła lub R by rozejrzeć się po celi";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        } else if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.cell_mirror;
        }
    }
    void state_lock_0() {
        text.text = "Zamek w drzwiach nie wygladą na cud techniki,  " +
                    "gdybym tylko miał coś czym mógłbym " + // \n new line
                    "przekręcić zamek i wydostać się stąd \n\n"+
                    "Kliknij R by rozejrzec się po celi ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        } 
    }
    void state_cell_mirror() {
        text.text = "Jesteś więźniem w celi, i chcesz z niej uciec. Widzisz " +
                    "jakąś brudną koszulkę na łóżku, masz kawalek lustra w rece i drzwi " + // \n new line
                    "które sa zamknięte od zewnątrz .\n\n\n" +
                    "Kliknij S by spojrzeć na koszulkę lub L by sprawdzić drzwi.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sheets_1;
        } else if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.lock_1;
        }
    }
    void state_sheets_1() {
        text.text = "Ta koszulka nadal nie wygląda zachęcająco, " +
                    "wątpie by mi się do czegoś przydała " + // \n new line
                    "Tak myslę. \n\n" +
                    "Kliknij R by rozejrzeć sie po celi";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell_mirror;
        }
    }
    void state_lock_1() {
        text.text = "Ten kawalek lustra powinien się nadawać,  " +
                    "wystarczy tylko troche przekręcić,  " + // \n new line
                    "i powinienem być wolny! \n\n" +
                    "Kliknij R by wóocić do celi lub Kliknij O by otworzyć ";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell_mirror;
        } else if (Input.GetKeyDown(KeyCode.O)) {
            myState = States.freedom;
        }
    }
    void state_freedom()
    {
        text.text = "Udało sie! Jestem wolny! " +
                    "\n\n  " + // \n new line
                    "Gratulacje udało ci się uciec ! \n\n\n\n" +
                    "Kliknij P by zagrać ponownie";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.mirror;
        }
    }
}
