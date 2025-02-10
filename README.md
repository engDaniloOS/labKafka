# Laboratório Kafka

Esse projeto tem como objetivo estudar a criação de producer e consumer em Kafka, utilizando .net (C#)

## Pré-requisitos
- Docker;
- .net 8;

Para execução do projeto precisamos simular o Kafka em ambiente local, utilizando o docker. Em vista disso, na raiz do projeto, devemos executar o docker-compose, que criará o Zookeeper, Kafka e tópico a ser utilizado pelas apps. Segue comando a ser executado no cmd:
```bash
docker-compose up -d
```

## Projeto

Na solução temos dois projetos:
- Producer Kafka: API com método POST para criação de proposta de crédito. Ao realizar o request, a app irá publicar a proposta no tópico;
- Consumer Kafka: Tem um listener Kafka que escuta ativamente o tópico, e ao receber uma mensagem, a salva em uma base de dados local. Essa app também tem uma API com método GET, que permite consultar as propostas salvas.