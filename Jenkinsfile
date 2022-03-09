

def nothing = "nothing"



node
{
    parameters {
    string(name: 'paramA', defaultValue: 'Hello', description: 'How should I greet the world?')
}

    stage ('Cyka'){
        def prod_or_sandbox = input message: 'Production or Sandbox', parameters: [choice(choices: ['Production', 'Sandbox'], description: '', name: 'DeployTo')]
        echo "Deploying to ${prod_or_sandbox}"
    }

    stage('Hello')
    {
        echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
    }

    stage('Build'){
        echo "Building ${params.paramA}"
    }

    
}