﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.ComponentModel;

public class ParameterPresenter : MonoBehaviour {

    public StatusModel model;

    public ParameterViewBase healthView;

    void Awake()
    {
        model.PropertyChanged += Model_PropertyChanged;
        Model_PropertyChanged(model, new PropertyChangedEventArgs("")); // 開始時に値を発生させる用
    }

    private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        healthView.SetParameter(model.HealthMax, model.Health);
    }
}
