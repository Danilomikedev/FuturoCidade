Feature: Alertas de Seguran�a

  Scenario: Criar um novo alerta
    Given que um alerta com a mensagem "Incidente na Avenida" 
    When o alerta � criado
    Then o sistema deve retornar o status 201

  Scenario: Listar alertas
    Given alertas est�o cadastrados
    When a lista de alertas � solicitada
    Then o sistema deve retornar o status 200 e a lista de alertas
