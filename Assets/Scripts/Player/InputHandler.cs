﻿using System.Collections;
using UnityEngine;


    public class InputHandler : MonoBehaviour
    {

    public float verInput { get; private set; }
    public float horInput { get; private set; }
    public bool sprinting { get; private set; }
    public bool aiming { get; private set; }
    public bool shooting { get; private set; }
    public bool looking { get; private set; }
    public float mouseX { get; private set; }
    public float mouseY { get; private set; }
    public static InputHandler instance { get; private set; }
    private void Start()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        verInput = Input.GetAxis("Vertical");
        horInput = Input.GetAxis("Horizontal");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        aiming = Input.GetButton("Fire2");
        shooting = Input.GetButton("Fire1");
        looking = Input.GetButton("Jump");
        sprinting = Input.GetButton("Sprint");
    }
}
