using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStat
{
    #region Properties
    //ĳ���� ü��
    public int HP { get; set; }

    //ĳ���� ����
    public int MP { get; set; }
    
    //ĳ���� �̵� �ӵ�
    public float Speed { get; set; }

    //ĳ���� ����
    public int DEF { get; set; }

    //ĳ���� ���ݷ�
    public float AttackPower { get; set; }

    //ĳ���� ���ݼӵ�
    public float AttackSpeed { get; set; }

    //���� ȸ�� Ȯ��
    public float DodgeProb { get; set; }

    //ũ��Ƽ�� Ȯ��
    public float CriticalProb { get; set; }
    #endregion
}
