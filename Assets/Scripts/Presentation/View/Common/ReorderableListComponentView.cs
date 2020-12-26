﻿using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectBlue.RepulserEngine
{
    public abstract class ReorderableListComponentView<T> : MonoBehaviour
    {

        [SerializeField] protected TMP_Text indexText;
        [SerializeField] protected Button upButton;
        [SerializeField] protected Button deleteButton;
        [SerializeField] protected Button downButton;

        [SerializeField] protected Image backgroundImage;
        [SerializeField] private Color defaultBackground = Color.gray;

        public int Index => transform.GetSiblingIndex();
        
        public void Initialize(Action onDeleteAction, Action onUpAction, Action onDownAction)
        {
            deleteButton.OnClickAsObservable().Subscribe(_ =>
            {
                onDeleteAction?.Invoke();
                Destroy(gameObject);
            }).AddTo(this);

            upButton.OnClickAsObservable().Subscribe(_ =>
            {
                onUpAction?.Invoke();
            }).AddTo(this);

            downButton.OnClickAsObservable().Subscribe(_ =>
            {
                onDownAction?.Invoke();
            }).AddTo(this);
        }

        public void UpdateIndex()
        {
            indexText.text = $"{Index:D2}";
        }

        protected void SetDirty()
        {
            ChangeBackgroundColor(Color.red);
        }
        
        public void SetBackgroundSaved()
        {
            ChangeBackgroundColor(defaultBackground);
        }

        public void ChangeBackgroundColor(Color color)
        {
            backgroundImage.color = color;
        }

        public abstract void UpdateView(T data);
        
    }

}