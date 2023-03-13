using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    Author: Quincy Muzik 
    Script Name: GUI_Listeners.cs
    Project Name: CS 326 Module 1.2 Product Customizer
    Date: 3/13/2023
 */
public class GUI_Listeners : MonoBehaviour
{
    // Index into the reciever, handgaurd and barrel arrays
    private int currentReciever = 0;
    private int currentHandgaurd = 0;
    private int currentBarrel = 0;

    // Arrays of reciever, handguards, and barrels Game Objects
    private GameObject[] gunRecievers;
    private GameObject[] gunHandguards;
    private GameObject[] gunBarrels;

    [SerializeField]
    private Toggle firstChoice;

    [SerializeField]
    private Toggle secondChoice;
    
    [SerializeField]
    private GameObject stock1;

    [SerializeField]
    private GameObject stock2;

    [SerializeField]
    private GameObject stock3;

    [SerializeField]
    private GameObject stock4;

    [SerializeField]
    private GameObject scope1;

    [SerializeField]
    private GameObject scope2;

    [SerializeField]
    private GameObject scope3;

    [SerializeField]
    private GameObject scope4;

    [SerializeField]
    private GameObject handle1;

    [SerializeField]
    private GameObject handle2;

    [SerializeField]
    private GameObject underbarrel1;

    [SerializeField]
    private GameObject underbarrel2;

    [SerializeField]
    private GameObject underbarrel3;

    [SerializeField]
    private GameObject underbarrel4;

    [SerializeField]
    private GameObject exitConfirmationWindow;

    [SerializeField]
    private GameObject resetConfirmationWindow;

    [SerializeField]
    private GameObject orderConfirmationWindow;

    [SerializeField]
    private GameObject finalOrderConfirmationWindow;

    // Start is called before the first frame update
    void Start()
    {
        // Finds the recievers by tag
        gunRecievers = GameObject.FindGameObjectsWithTag("Reciever");
        if (gunRecievers.Length < 1)
        {
            Debug.LogWarning("No Recievers found in GUI_Listeners");
        }

        // Finds the handgaurds by tag
        gunHandguards = GameObject.FindGameObjectsWithTag("Handgaurd");
        if (gunHandguards.Length < 1)
        {
            Debug.LogWarning("No Handgaurds found in GUI_Listeners");
        }

        // Finds the barrels by tag
        gunBarrels = GameObject.FindGameObjectsWithTag("Barrel");
        if (gunBarrels.Length < 1)
        {
            Debug.LogWarning("No Barrels found in GUI_Listeners");
        }

        // Disable recievers
        foreach (var reciever in gunRecievers)
        {
            reciever.SetActive(false);
        }

        // Disable handgaurds
        foreach (var handGaurd in gunHandguards)
        {
            handGaurd.SetActive(false);
        }

        // Disable barrels
        foreach (var barrel in gunBarrels)
        {
            barrel.SetActive(false);
        }

        // Make current reciever active
        if (gunRecievers[currentReciever] != null)
        {
            gunRecievers[currentReciever].SetActive(true);
            Debug.Log("Default Receiver Set");
        }
        else
        {
            Debug.LogWarning("Unexpected null Reciever in GUI_Listeners");
        }

        // Make current handguard active
        if (gunHandguards[currentHandgaurd] != null)
        {
            gunHandguards[currentHandgaurd].SetActive(true);
            Debug.Log("Default Handgaurd Set");
        }
        else
        {
            Debug.LogWarning("Unexpected null Handgaurd in GUI_Listeners");
        }

        // Make current barrel active
        if (gunBarrels[currentBarrel] != null)
        {
            gunBarrels[currentBarrel].SetActive(true);
            Debug.Log("Default Barrel Set");
        }
        else
        {
            Debug.LogWarning("Unexpected null Barrel in GUI_Listeners");
        }

        // Default Stock Value (None)
        stock1.SetActive(false);
        stock2.SetActive(false);
        stock3.SetActive(false);
        stock4.SetActive(false);
        Debug.Log("Default Stock (None) has Been Selected");

        // Default Scope Value (None)
        scope1.SetActive(false);
        scope2.SetActive(false);
        scope3.SetActive(false);
        scope4.SetActive(false);
        Debug.Log("Default Scope (None) has Been Selected");

        // Make default handle (1) active 
        handle1.SetActive(true);
        handle2.SetActive(false);
        Debug.Log("Default Handle has Been Selected");

        // Default Underbarrel Value (None)
        underbarrel1.SetActive(false);
        underbarrel2.SetActive(false);
        underbarrel3.SetActive(false);
        underbarrel4.SetActive(false);
        Debug.Log("Default Underbarrel (None) has Been Selected");

        // Turn off Confirmation Window at Start
        exitConfirmationWindow.SetActive(false);

        // Turn off Reset Window Cofirmation at Start
        resetConfirmationWindow.SetActive(false);

        // Turn off Order window confirmation at Start
        orderConfirmationWindow.SetActive(false);

        // Turn off final order window confirmation at Start
        finalOrderConfirmationWindow.SetActive(false);
    }

    // Top Panel UI elements
    public void onRecieverButtonClicked()
    {
        gunRecievers[currentReciever].SetActive(false);
        currentReciever = (currentReciever + 1) % gunRecievers.Length;
        gunRecievers[currentReciever].SetActive(true);
        Debug.Log("Reciever Has Been Changed");
    }

    public void onHandGaurdButtonClicked()
    {
        gunHandguards[currentHandgaurd].SetActive(false);
        currentHandgaurd = (currentHandgaurd+ 1) % gunHandguards.Length;
        gunHandguards[currentHandgaurd].SetActive(true);
        Debug.Log("Handgaurd Has Been Changed");
    }

    public void onBarrelButtonClicked()
    {
        gunBarrels[currentBarrel].SetActive(false);
        currentBarrel = (currentBarrel + 1) % gunBarrels.Length;
        gunBarrels[currentBarrel].SetActive(true);
        Debug.Log("Barrel Has Been Changed");
    }

    public void stockSelector(int value)
    {
        if (value == 0)
        {
            stock1.SetActive(false);
            stock2.SetActive(false);
            stock3.SetActive(false);
            stock4.SetActive(false);
            Debug.Log("No Stock has Been Selected");
        }

        else if (value == 1)
        {
            stock1.SetActive(true);
            stock2.SetActive(false);
            stock3.SetActive(false);
            stock4.SetActive(false);
            Debug.Log("Stock 1 has Been Selected");
        }

        else if (value == 2)
        {
            stock1.SetActive(false);
            stock2.SetActive(true);
            stock3.SetActive(false);
            stock4.SetActive(false);
            Debug.Log("Stock 2 has Been Selected");
        }

        else if (value == 3)
        {
            stock1.SetActive(false);
            stock2.SetActive(false);
            stock3.SetActive(true);
            stock4.SetActive(false);
            Debug.Log("Stock 3 has Been Selected");
        }

        else
        {
            stock1.SetActive(false);
            stock2.SetActive(false);
            stock3.SetActive(false);
            stock4.SetActive(true);
            Debug.Log("Stock 4 has Been Selected");
        }
    }

    public void scopeSelector(int value)
    {
        if (value == 0)
        {
            scope1.SetActive(false);
            scope2.SetActive(false);
            scope3.SetActive(false);
            scope4.SetActive(false);
            Debug.Log("No Scope has Been Selected");
        }

        else if (value == 1)
        {
            scope1.SetActive(true);
            scope2.SetActive(false);
            scope3.SetActive(false);
            scope4.SetActive(false);
            Debug.Log("Scope 1 has Been Selected");
        }

        else if (value == 2)
        {
            scope1.SetActive(false);
            scope2.SetActive(true);
            scope3.SetActive(false);
            scope4.SetActive(false);
            Debug.Log("Scope 2 has Been Selected");
        }

        else if (value == 3)
        {
            scope1.SetActive(false);
            scope2.SetActive(false);
            scope3.SetActive(true);
            scope4.SetActive(false);
            Debug.Log("Scope 3 has Been Selected");
        }

        else 
        {
            scope1.SetActive(false);
            scope2.SetActive(false);
            scope3.SetActive(false);
            scope4.SetActive(true);
            Debug.Log("Scope 4 has Been Selected");
        }
    }

    public void handleToggle()
    {
        if (firstChoice.isOn)
        {
            handle1.SetActive(true);
            handle2.SetActive(false);
            Debug.Log("Handle 1 has Been Selected");
        }

        else if (secondChoice.isOn)
        {
            handle1.SetActive(false);
            handle2.SetActive(true);
            Debug.Log("Handle 2 has Been Selected");
        }
    }

    public void underbarrelSelector(int value)
    {
        if (value == 0)
        {
            underbarrel1.SetActive(false);
            underbarrel2.SetActive(false);
            underbarrel3.SetActive(false);
            underbarrel4.SetActive(false);
            Debug.Log("No Underbarrel has Been Selected");
        }

        else if (value == 1)
        {
            underbarrel1.SetActive(true);
            underbarrel2.SetActive(false);
            underbarrel3.SetActive(false);
            underbarrel4.SetActive(false);
            Debug.Log("Underbarrel 1 has Been Selected");
        }

        else if (value == 2)
        {
            underbarrel1.SetActive(false);
            underbarrel2.SetActive(true);
            underbarrel3.SetActive(false);
            underbarrel4.SetActive(false);
            Debug.Log("Underbarrel 2 has Been Selected");
        }

        else if (value == 3)
        {
            underbarrel1.SetActive(false);
            underbarrel2.SetActive(false);
            underbarrel3.SetActive(true);
            underbarrel4.SetActive(false);
            Debug.Log("Underbarrel 3 has Been Selected");
        }

        else
        {
            underbarrel1.SetActive(false);
            underbarrel2.SetActive(false);
            underbarrel3.SetActive(false);
            underbarrel4.SetActive(true);
            Debug.Log("Underbarrel 4 has Been Selected");
        }
    }

    // Bottom Panel Buttons 
    public void exitButtonClicked()
    {
        exitConfirmationWindow.SetActive(true);
        Debug.Log("Exit Button Pressed.");
    }

    public void resetButtonClicked()
    {
        resetConfirmationWindow.SetActive(true);
        Debug.Log("Reset Button Pressed.");
    }

    public void placeOrderButtonClicked()
    {
        orderConfirmationWindow.SetActive(true);
        Debug.Log("Place Order Button Pressed");

    }

    // Exit Confirmation Window Button
    public void exitYesButtonClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Yes Button Clicked.");
        Application.Quit();
    }

    public void exitNoButtonClicked()
    {
        exitConfirmationWindow.SetActive(false);
        Debug.Log("No Button Clicked.");
    }

    // Reset Confirmation Window Button
    public void resetYesButtonClicked()
    {
        // Default Stock Value (None)
        stock1.SetActive(false);
        stock2.SetActive(false);
        stock3.SetActive(false);
        stock4.SetActive(false);

        // Default Scope Value (None)
        scope1.SetActive(false);
        scope2.SetActive(false);
        scope3.SetActive(false);
        scope4.SetActive(false);

        // Make default handle (1) active 
        handle1.SetActive(true);
        handle2.SetActive(false);

        // Default Underbarrel Value (None)
        underbarrel1.SetActive(false);
        underbarrel2.SetActive(false);
        underbarrel3.SetActive(false);
        underbarrel4.SetActive(false);

        resetConfirmationWindow.SetActive(false);
        Debug.Log("Parts set back to defaults");
    }

    public void resetNoButtonClicked()
    {
        resetConfirmationWindow.SetActive(false);
        Debug.Log("No Button Clicked.");

    }

    // Place Order Confirmation Window Button
    public void placeOrderYesButtonClicked()
    {
        orderConfirmationWindow.SetActive(false);
        finalOrderConfirmationWindow.SetActive(true);
        Debug.Log("Yes Button Clicked.");
    }

    public void placeOrderNoButtonClicked()
    {
        orderConfirmationWindow.SetActive(false);
        Debug.Log("Place Order Button Clicked.");
    }

    // The User clicks yes for order confirmation 
    public void continueShoppingButtonClicked()
    {
        finalOrderConfirmationWindow.SetActive(false);
        Debug.Log("Continue Shopping Button Clicked.");
    }

    public void doneShoppingButtonClicked()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("Continue Shopping Button Clicked.");
    }
}
