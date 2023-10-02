
#include <iostream>
#include "estruturas.h"

// ArovreBinária

Node *BinaryTree::getroot()
{
    return root;
}

void BinaryTree::add(int x)
{
    if (root == nullptr)
    {
        root = new Node(x);
    }
    if (search(root, x) == false)
    {
        insertRecursive(root, x);
    }
}

void BinaryTree::insertRecursive(Node *currentNode, int value)
{
    if (value < currentNode->data)
    {
        if (currentNode->left == nullptr)
        {
            currentNode->left = new Node(value);
        }
        else
        {
            insertRecursive(currentNode->left, value);
        }
    }
    else
    {
        if (currentNode->right == nullptr)
        {
            currentNode->right = new Node(value);
        }
        else
        {
            insertRecursive(currentNode->right, value);
        }
    }
}

bool BinaryTree::search(Node *currentNode, int value)
{
    if (currentNode == nullptr)
    {
        return false;
    }

    if (value == currentNode->data)
    {
        return true;
    }
    else if (value < currentNode->data)
    {
        return search(currentNode->left, value);
    }
    else
    {
        return search(currentNode->right, value);
    }
}

void BinaryTree::print()
{
    print_(root);
    std::cout << std::endl;
}

void BinaryTree::print_(Node *currentNode)
{
    if (currentNode != nullptr)
    {
        print_(currentNode->left);
        std::cout << currentNode->data << " ";
        print_(currentNode->right);
    }
}

int BinaryTree::getnos()
{
    if (root == nullptr)
    {
        return 0;
    }

    return getnos_recursive(root);
}

int BinaryTree::getnos_recursive(Node *no)
{
    if (no != nullptr)
    {
        int nos = 1 + getnos_recursive(no->left) + getnos_recursive(no->right);
        return nos;
    }
    return 0;
}

int BinaryTree::altura()
{
    if(root != nullptr){
        return altura_(root, 1);
}
    }
    

int BinaryTree::altura_(Node *no, int altura)
{
    if (no->left == nullptr && no->right != nullptr)
    {
        
        int altura1 = altura_(no->right, altura + 1);
        return altura1;
    }
    if (no->right == nullptr && no->left != nullptr)
    {
       
        int altura2 = altura_(no->left, altura + 1);
        return altura2;
    }
    if(no->right != nullptr && no->left != nullptr){
        
        int altura1 = altura_(no->left, altura + 1);
        int altura2 = altura_(no->right, altura + 1);
        if (altura1 > altura2)
        {
            
            return altura1;
        }
        else
        {
           
            return altura2;
        }
    }
    
    return altura;

}

int BinaryTree::folhas()
{
    if (root != nullptr)
    {
        return folhas_(root);
    }
}

int BinaryTree::folhas_(Node *no)
{
    if (no->left == nullptr && no->right == nullptr)
    {
        return 1;
    }
    if (no->left == nullptr)
    {
        return folhas_(no->right);
    }
    if (no->right == nullptr)
    {
        return folhas_(no->left);
    }
    else
    {
        return (folhas_(no->left) + folhas_(no->right));
    }
}

bool BinaryTree::comparar(BinaryTree B)
{
    return comparar_(root, B.root);
}

bool BinaryTree::comparar_(Node *A, Node *B)
{
    if (A == nullptr && B == nullptr)
    {
        return true;
    }
    if (A == nullptr && B != nullptr)
    {
        return false;
    }
    if (A != nullptr && B == nullptr)
    {
        return false;
    }
    return (A->data == B->data) && comparar_(A->left, B->left) && comparar_(A->right, B->right);
}

std::string BinaryTree::pre_ordem()
{
    if (root != nullptr)
    {
        return pre_ordem_(root);
    }
}

std::string BinaryTree::pre_ordem_(Node *no)
{
    std::string ordem = "";
    if (no->left != nullptr)
    {
        ordem = ordem + " " + pre_ordem_(no->left);
    }
    if (no->right != nullptr)
    {
        ordem = ordem + " " + pre_ordem_(no->right);
    }
    return (std::to_string(no->data) + ordem);
}

std::string BinaryTree::em_ordem()
{
    if (root != nullptr)
    {
        return em_ordem_(root);
    }
}

std::string BinaryTree::em_ordem_(Node *no)
{
    std::string ordem = "";
    if (no->left != nullptr)
    {
        ordem = ordem + " " + em_ordem_(no->left);
    }

    ordem = ordem + " " + std::to_string(no->data);

    if (no->right != nullptr)
    {
        ordem = ordem + " " +em_ordem_(no->right);
    }

    return ordem;
}

std::string BinaryTree::pos_ordem()
{
    if (root != nullptr)
    {
        return pos_ordem_(root);
    }
}

std::string BinaryTree::pos_ordem_(Node *no)
{
    std::string ordem = "";
    if (no->left != nullptr)
    {
        ordem = ordem + " " + pos_ordem_(no->left);
    }
    if (no->right != nullptr)
    {
        ordem = ordem + " " + pos_ordem_(no->right);
    }
    ordem = ordem + " " + std::to_string(no->data);

    return ordem;
}

// ArvoreAVL

No::No(int valor)
{
    this->valor = valor;
    esquerda = nullptr;
    direita = nullptr;
    altura = 1;
}

ArvoreAVL::ArvoreAVL()
{
    raiz = nullptr;
    std::cout << "Árvore criada " << std::endl;
}

int ArvoreAVL::maximo(int a, int b)
{
    return (a > b) ? a : b;
}

int ArvoreAVL::altura(No *no)
{
    if (no == nullptr)
        return 0;
    return no->altura;
}

int ArvoreAVL::fatorBalanceamento(No *no)
{
    if (no == nullptr)
        return 0;
    return altura(no->esquerda) - altura(no->direita);
}

No *ArvoreAVL::rotacaoDireita(No *y)
{
    No *x = y->esquerda;
    No *T2 = x->direita;

    // Realiza a rotação
    x->direita = y;
    y->esquerda = T2;

    // Atualiza as alturas dos nós afetados
    y->altura = maximo(altura(y->esquerda), altura(y->direita)) + 1;
    x->altura = maximo(altura(x->esquerda), altura(x->direita)) + 1;

    return x; // Retorna o novo nó raiz
}

No *ArvoreAVL::rotacaoEsquerda(No *x)
{
    No *y = x->direita;
    No *T2 = y->esquerda;

    // Realiza a rotação
    y->esquerda = x;
    x->direita = T2;

    // Atualiza as alturas dos nós afetados
    x->altura = maximo(altura(x->esquerda), altura(x->direita)) + 1;
    y->altura = maximo(altura(y->esquerda), altura(y->direita)) + 1;

    return y; // Retorna o novo nó raiz
}

No *ArvoreAVL::inserir(No *no, int valor)
{
    if (no == nullptr)
        return new No(valor);

    if (valor < no->valor)
    {
        std::cout << valor << " menor que " << no->valor << std::endl;
        no->esquerda = inserir(no->esquerda, valor);
    }

    else if (valor > no->valor)
    {
        std::cout << valor << " maior que " << no->valor << std::endl;
        no->direita = inserir(no->direita, valor);
    }
    else
        return no; // Valor
    // Atualiza a altura do nó atual
    no->altura = 1 + maximo(altura(no->esquerda), altura(no->direita));
    std::cout << "Altura de " << no->valor << "= " << no->altura << std::endl;

    // Calcula o fator de balanceamento do nó atual
    int fator = fatorBalanceamento(no);
    std::cout << "FatorBalenceamento de " << no->valor << "= " << fator << std::endl;

    // Verifica se é necessário fazer rotações para balancear a árvore
    if (fator > 1 && valor < no->esquerda->valor)
    {
        std::cout << no->valor << " fez 1 rotação direita" << std::endl;
        return rotacaoDireita(no);
    }

    if (fator < -1 && valor > no->direita->valor)
    {
        std::cout << no->valor << " fez 1 rotação esquerda" << std::endl;
        return rotacaoEsquerda(no);
    }

    if (fator > 1 && valor > no->esquerda->valor)
    {
        std::cout << no->valor << " fez 1 rotação esquerda e 1 direita" << std::endl;
        no->esquerda = rotacaoEsquerda(no->esquerda);
        return rotacaoDireita(no);
    }

    if (fator < -1 && valor < no->direita->valor)
    {
        std::cout << no->valor << " fez 1 rotação direita e 1 esquerda" << std::endl;
        no->direita = rotacaoDireita(no->direita);
        return rotacaoEsquerda(no);
    }

    return no; // Retorna o nó atual (não houve rotações)
}

void ArvoreAVL::inserir(int valor)
{
    std::cout << "inserindo " << valor << std::endl;
    raiz = inserir(raiz, valor);
}

void ArvoreAVL::print()
{
    print(raiz);
    std::cout << std::endl;
}

void ArvoreAVL::print(No *currentNode)
{
    if (currentNode != nullptr)
    {
        print(currentNode->esquerda);
        std::cout << currentNode->valor << " ";
        print(currentNode->direita);
    }
}
