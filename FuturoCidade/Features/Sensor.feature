Feature: Gerenciamento de Sensores Ambientais

  Scenario: Adicionar um novo sensor
    Given que um sensor ambiental com tipo "Temperatura" e valor 25.0
    When o sensor � adicionado
    Then o sistema deve retornar o status 201

  Scenario: Listar sensores
    Given sensores est�o cadastrados
    When a lista de sensores � solicitada
    Then o sistema deve retornar o status 200 e a lista de sensores
