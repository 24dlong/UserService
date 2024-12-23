export DOCKER_BUILDKIT   := 1
export PROJECT_SLUG 	 := user-service

bootstrap:
	@./scripts/docker-compose-up.sh '-f ./docker-compose.yml' -d

build:
	docker compose build ${PROJECT_SLUG}
