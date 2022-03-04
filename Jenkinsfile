node
{
    parameters {
        string(name: 'paramA', defaultValue: 'Hello', description: 'How should I greet the world?')
    }
    stages{
        stage('Hello')
        {
            steps{
                echo "Running ${env.BUILD_ID} on ${env.JENKINS_URL}"
            }
        }
        stage('Build'){
            steps{
                echo "Building ${params.paramA}"
            }
        }
    }
}