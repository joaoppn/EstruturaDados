#ifndef ARVORE_BINARIA_H
#define ARVORE_BINARIA_H

#include <iostream>
#include <string>
#include <vector>

class Node {
public:
    int data;
    Node* left;
    Node* right;

    Node(int x) {
        data = x;
        left = nullptr;
        right = nullptr;
    };
};

class BinaryTree {
public:
    Node* root;

public:
    BinaryTree() {
        root = nullptr;
    }
    BinaryTree(std::vector<int> vetor){
        root = nullptr;
        for(int i:vetor){
            add(i);
        }
    }

    Node* getroot();

    void add(int x);

    void insertRecursive(Node* currentNode, int value);

    bool search(Node* currentNode, int value);

    void print();

    void print_(Node* currentNode);

    int getnos();

    int getnos_recursive(Node* no);

    int altura();

    int altura_(Node* no, int altura);

    int folhas();

    int folhas_(Node* no);

    bool comparar(BinaryTree B);

    bool comparar_(Node* A, Node* B);

    std::string pre_ordem();

    std::string pre_ordem_(Node* no);

    std::string em_ordem();

    std::string em_ordem_(Node* no);

    std::string pos_ordem();

    std::string pos_ordem_(Node* no);
};

class No {
public:
    int valor;
    No* esquerda;
    No* direita;
    int altura;

    No(int valor);
};

class ArvoreAVL {
private:
    No* raiz;

    int maximo(int a, int b);
    int altura(No* no);
    int fatorBalanceamento(No* no);
    No* rotacaoDireita(No* y);
    No* rotacaoEsquerda(No* x);
    No* inserir(No* no, int valor);
    void preOrdem(No* no);
    void print(No* no);


public:
    ArvoreAVL();
    void inserir(int valor);
    void print();
};


#endif
