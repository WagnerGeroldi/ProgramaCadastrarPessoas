# ProgramaCadastrarPessoas

Avaliação Discursiva | Matéria - Programação Orientada a Objetos | Graduação - Análise e Desenvolvimento de Sistemas

Linguagem de Programação Utilizada > 100% C#


A avaliação consiste em desenvolver um software Desktop, onde serão cadastradas pessoas para analisar entre homens e mulheres, se trabalham ou não e suas devidas porcentagens no
cenário!

Foi desenvolvido um gráfico para auxiliar e uma opção de gerar PDF do resultado!

Tela Inicial do Programa

![tela inicial](https://user-images.githubusercontent.com/74829196/142636336-2b034f7e-5709-44f7-98f6-29bbf7b139b5.png)


Tela de cadastro

![tela cadastro](https://user-images.githubusercontent.com/74829196/142636602-7d38f29c-2829-4450-ba95-9054d5f628d3.png)

A tela de cadastro possui 80% da lógica do programa.
No grupo cadastro é possível cadastrar individualmente as pessoas, o botão salvar possui mecanismo que não permite salvar caso o usuário esteja com algum dado vazio.
O botão excluir não permite excluir caso não tenha algum usuário selecionado na listagem.

No grupo ações, existe um botão para gerar o relatório, o mesmo possui um mecanismo que emite um alerta, nao permitindo a criação do relatório caso a lista esteja vazia.
O botão preecher automaticamente foi criado para gerar uma lista de 50 pessoas para fins de testes e para que o professor não precise digitar manualmente ao avaliar o programa. Este botão possui mecanismos para alertar o usuário caso a lista já contenha itens e pede permissões de limpeza da lista antes de gerar automaticamente. Caso a lista esteja vazia ele verifica isso antes e não emite alertas.

O botão limpar lista simplesmente limpa a lista após a permissão do usuário.


TELA DO RELATÓRIO

![relatório](https://user-images.githubusercontent.com/74829196/142637811-a01bf82e-2964-40be-a3c5-9413c495af53.png)


