#include <iostream>
#include <vector>
#include "estruturas.h"



int main(int argc, char const *argv[])
{
    BinaryTree teste = BinaryTree();
    BinaryTree B = BinaryTree();
    BinaryTree A = BinaryTree();

    teste.add(4);
    teste.add(9);
    teste.add(6);
    teste.add(10);
    teste.add(18);
    teste.add(1);
    teste.add(8);

    A.add(4);
    A.add(9);
    A.add(6);
    A.add(10);
    A.add(18);
    A.add(1);
    A.add(8);

    B.add(4);
    B.add(9);
    B.add(6);

    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 1:" << std::endl;

    //Q1
    std::cout << "Altura de A: "<< A.altura();
    std::cout<<std::endl;
    std::cout << "Altura de B:" << B.altura();
    std::cout<<std::endl;


    //Q2

    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 2:" << std::endl;


    std::cout << "Nós A:" << A.getnos();
    std::cout << std::endl;
    std::cout << "Nós B:" << B.getnos();
    std::cout << std::endl;

    //Q3

    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 3:" << std::endl;

    std::cout << "Folhas A:" << A.folhas();
    std::cout << std::endl;
    std::cout << "Folhas B:" << B.folhas();
    std::cout << std::endl;
    
    //Q4

    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 4:" << std::endl;

    if(teste.comparar(A)){
        std::cout << "teste é Igual a A" << std::endl;
    }
    else{
        std::cout << "teste não é igual a A" << std::endl;
    }


    if(teste.comparar(B)){
        std::cout << "teste é Igual a B" << std::endl;
    }
    else{
        std::cout << "teste não é igual a B" << std::endl;
    }

    //Q5
    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 5:" << std::endl;

    std::cout << "Pre Orde:" << A.pre_ordem();
    std::cout<<std::endl;
    std::cout << "em Ordem: " << A.em_ordem();
    std::cout<<std::endl;
    std::cout<<"Pos Ordem:" << A.pos_ordem();
    std::cout<<std::endl;

    //Q6 - Pior caso de um ABB seria para o caso de uma árvore em ordem. 

    //Q7
    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 7:" << std::endl;

    std::vector<int> vetor = {67, 3, 47, 9, 7, 4, 2, 45, 1};
    BinaryTree new_vetor = BinaryTree(vetor);
    new_vetor.print();
    new_vetor.add(10);
    new_vetor.add(56);
    new_vetor.add(100);
    new_vetor.print();



    //Q9 - um fator de balanceamento igual a +3 não é possível em uma árvore AVL, todas as subárvores têm alturas 
    //iguais ou diferença máxima de 1, e tem fator de balancemento igual -1, 0 ou +1.  Quando o fator de balanceamento passa disso, acontece uma rotação.

    //Q10 - <1, 2, 3, 4, 5, 6, 7
    std::cout<<std::endl;
    std::cout<<std::endl;
    std::cout<<"Questão 10:" << std::endl;
    ArvoreAVL D = ArvoreAVL();
    D.inserir(1);
    D.inserir(2);
    D.inserir(3);
    D.inserir(4);
    D.inserir(5);
    D.inserir(6);
    D.inserir(7);

    D.print();



    return 0;
}
